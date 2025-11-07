namespace MSO3
{
    internal static class Program
    {
        static Form1 form;
        static Character character = new Character();
        static List<ICommand> commands = new List<ICommand>();
        public static Tile[,]? currentGrid;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            form = new Form1();
            Application.Run(form);
        }

        public static void RunCurrentProgram()
        {
            if (currentGrid == null)
            {
                WarnUser("cannot run program without valid grid");
                return;
            }

            commands = InputReader.GetCommands(form.InputTextBox.Text);

            for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute(character);
            }

            commands.Clear();
        }
        public static void WarnUser(string warning)
        {
            form.OutPutTextBox.Text = "Warning: " + warning;
        }

        public static void LoadGrid(Tile[,] grid, Panel gridPanel)
        {
            currentGrid = grid;
            character.grid = grid; // set characters grid to the current grid
            gridPanel.Refresh();
        }
    }
}