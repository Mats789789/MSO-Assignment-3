
using System.Diagnostics;
using MSO3;

public class InputReader
{
    IProgramController program;

    public InputReader(IProgramController program)
    {
        this.program = program;
    }

    public static List<string> GetLinesTxt(string input)
    {
        return input.Split(new[] {"\n", "\r\n", "\r"}, StringSplitOptions.None).ToList();
    }

    private List<ICommand> ParseCommands(List<string> lines)
    {
        List<ICommand> commands = new List<ICommand>();
        int line = 0;

        while (line < lines.Count)
        {
            string raw = lines[line].Trim();

            if (raw.StartsWith("RepeatUntil"))
            {
                string condition = raw.Split(' ')[1];   //parse condition

                line++;
                List<string> nested = new List<string>();

                while (line < lines.Count && lines[line].StartsWith("    "))  //collect indented lines
                {
                    nested.Add(lines[line].Substring(4));
                    line++;
                }

                //recursively parse nested commands
                List<ICommand> nestedCommands = ParseCommands(nested);
                commands.Add(new RepeatUntilCommand(condition, nestedCommands));
            }
            else if (raw.StartsWith("Repeat"))
            { 
                int times = int.Parse(raw.Split(' ')[1]);   //parse times

                line++;
                List<string> nested = new List<string>();

                while (line < lines.Count && lines[line].StartsWith("    "))  //collect indented lines
                {
                    nested.Add(lines[line].Substring(4));
                    line++;
                }

                //recursively parse nested commands
                List<ICommand> nestedCommands = ParseCommands(nested);
                commands.Add(new RepeatCommand(times, nestedCommands));
            }
            else
            {
                string[] cut = lines[line].Split(' ');

                switch (cut[0])
                {
                    case "Move": 
                        {
                            if (int.TryParse(cut[1], out int parsed)) commands.Add(new MoveCommand(parsed));
                            else throw new InvalidCommandException(line);
                            break;
                        } 
                    case "Turn":
                        {
                            if(cut[1] == "left" || cut[1] == "right") commands.Add(new TurnCommand(cut[1]));
                            else throw new InvalidCommandException(line);
                            break;
                        }
                    case "": break;
                    default: throw new InvalidCommandException(line);
                }
                line++;
            }
        }

        return commands;
    }

    public List<ICommand> GetCommands(string input)
    {
        return ParseCommands(GetLinesTxt(input));
    }
}
