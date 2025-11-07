using Microsoft.VisualBasic.Logging;

namespace MSO3
{
    internal static class Program
    {
        static Form1 form;
        public static Character character = new Character();
        static List<ICommand> commands = new List<ICommand>();
        public static Tile[,]? currentGrid;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            form = new Form1();
            Application.Run(form);
        }

        public static void RunCurrentProgram(bool printMetrics)
        {
            character.Reset(); //
            form.WarningBox.Text = "";

            if (currentGrid == null)
            {
                WarnUser("cannot run program without valid grid");
                return;
            }

            commands = InputReader.GetCommands(form.InputTextBox.Text);
            string log = "";

            for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute(character);
                log += commands[i].LogExecute();

                if (character.OffGrid || character.OnBlockedTile) // check if invalid move was made
                {
                    WarnUser("character went to invalid square");
                    break;
                }
            }

            if (printMetrics) log += "\r\n\r\n" + GetProgramMetrics(form.InputTextBox.Text, log);

            form.OutPutTextBox.Text = log;
            commands.Clear();

            //Draw character at termination
            form.programViewPanel.Refresh();
        }

        private static string GetProgramMetrics(string inputText, string log)
        {
            var lines = InputReader.GetLinesTxt(inputText);
            
            int numberOfCommands = log.Split(',').Count() - 1;
            int maxNesting = Metrics.MaxNesting(lines);
            int numberOfRepeats = Metrics.NumberOfRepeats(lines);

            return 
                $"NumberOfCommands: {numberOfCommands}\r\nMaxNesting: {maxNesting}\r\nNumberOfRepeats: {numberOfRepeats}";
        }
        
        public static void WarnUser(string warning)
        {
            form.WarningBox.Text = "Warning: " + warning;
        }

        public static void LoadGrid(Tile[,] grid, Panel gridPanel)
        {
            character.Reset();
            currentGrid = grid;
            character.grid = grid; // set characters grid to the current grid
            gridPanel.Refresh();
        }
    }
}