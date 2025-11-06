public interface ICommand
{
    void Execute(Character character);
}

public class MoveCommand : ICommand
{
    int distance;

    public MoveCommand(string distance)
    {
        this.distance = int.Parse(distance);
    }

    public void Execute(Character character)
    {
        character.Move(distance);
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
}

public class RepeatCommand : ICommand
{
    List<ICommand> commands;
    int timesExecuted;

    public RepeatCommand(int timesExecuted, List<ICommand> commands)
    {
        this.timesExecuted = timesExecuted;
        this.commands = commands;
    }

    public void Execute(Character character)
    {
        for (int j = 0; j < timesExecuted; j++)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute(character);
            }
        }
    }
}

public class RepeatUntilCommand : ICommand
{
    List<ICommand> commands;
    Func<Character, ICommand, bool> condition;

    public RepeatUntilCommand(string condition, List<ICommand> commands)
    {
        this.condition = condition switch
        {
            "nextCellIsWall" => (character, command) => NextCellIsWall(character, command),
            "nextCellIsEdge" => (character, command) => NextCellIsEdge(character, command),
            _ => throw new ArgumentException($"Unknown condition: {condition}")
        };

        this.commands = commands;
    }

    public void Execute(Character character)
    {
        bool cond = true;

        while (cond)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute(character);
            }
        }
    }

    private bool NextCellIsWall(Character character, ICommand nextCommand)
    {
        return false;
    }

    private bool NextCellIsEdge(Character character, ICommand nextCommand)
    {
        return false;
    }
}