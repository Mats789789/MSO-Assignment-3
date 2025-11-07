using MSO3;

public interface ICommand
{
    void Execute(Character character);
    string LogExecute();
}

public class MoveCommand : ICommand
{
    int distance;

    public MoveCommand(int distance)
    {
        this.distance = distance;
    }

    public void Execute(Character character)
    {
        character.Move(distance);
    }

    public string LogExecute()
    {
        return $"Move {distance}, ";
    }
}

public class TurnCommand : ICommand
{
    string direction;

    public TurnCommand(string direction)
    {
        this.direction = direction;
    }

    public void Execute(Character character)
    {
        character.Turn(direction);
    }

    public string LogExecute()
    {
        return $"Turn {direction}, ";
    }
}

public class RepeatCommand : ICommand
{
    List<ICommand> commands;
    int timesExecuted;
    string logs;

    public RepeatCommand(int timesExecuted, List<ICommand> commands)
    {
        this.timesExecuted = timesExecuted;
        this.commands = commands;
    }

    public void Execute(Character character)
    {
        string logsLocal = "";

        for (int j = 0; j < timesExecuted; j++)
        {
            bool invalidMoveMade = false;

            for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute(character);
                logsLocal += commands[i].LogExecute();

                if (character.OffGrid || character.OnBlockedTile) //check invalid position
                {
                    invalidMoveMade = true;
                    break;
                }
            }

            if (invalidMoveMade) break;
        }
        logs = logsLocal;
    }

    public string LogExecute()
    {
        return logs;
    }
}

public class RepeatUntilCommand : ICommand
{
    List<ICommand> commands;
    Func<Character, ICommand, bool> condition;
    string logs = "";

    public RepeatUntilCommand(string condition, List<ICommand> commands)
    {
        this.condition = condition switch
        {
            "wall" => NextCellIsWall,
            "edge" => NextCellIsEdge,
            _ => throw new ArgumentException($"Unknown condition: {condition}")
        };

        this.commands = commands;
    }

    public void Execute(Character character)
    {
        bool keepRunning = true;
        string logsLocal = "";

        if (commands.Count == 0) keepRunning = false;

        while (keepRunning)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                if (!condition(character, commands[i]) && !character.OffGrid && !character.OnBlockedTile) //check if command is valid
                {
                    commands[i].Execute(character);
                    logsLocal += commands[i].LogExecute();
                }
                else
                {
                    keepRunning = false;
                    break;
                }
            }
        }
        logs = logsLocal;
    }

    public string LogExecute()
    {
        return logs;
    }

    private bool NextCellIsWall(Character character, ICommand nextCommand)
    {
        Character dummy = new Character(character);

        nextCommand.Execute(dummy);

        if (dummy.OffGrid)
        {
            return false;
        }
        return dummy.OnBlockedTile;
    }

    private bool NextCellIsEdge(Character character, ICommand nextCommand)
    {
        Character dummy = new Character(character);

        nextCommand.Execute(dummy);

        return dummy.OffGrid;
    }
}