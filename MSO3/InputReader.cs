
using MSO3;

internal class InputReader
{
    private static List<string> GetLinesTxt(string input)
    {
        return input.Split(new[] {"\n", "\r\n", "\r"}, StringSplitOptions.None).ToList();
    }

    private static List<ICommand> ParseCommands(List<string> lines)
    {
        List<ICommand> commands = new List<ICommand>();
        int line = 0;

        while (line < lines.Count)
        {
            string raw = lines[line].Trim();

            if (raw.StartsWith("Repeat"))
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
                    case "Move": commands.Add(new MoveCommand(cut[1])); break;
                    case "Turn": commands.Add(new TurnCommand(cut[1])); break;

                    default: Program.WarnUser($"invalid syntax"); break;
                }
                line++;
            }
        }

        return commands;
    }

    public static List<ICommand> GetCommands(string input)
    {
        return ParseCommands(GetLinesTxt(input));
    }
}
