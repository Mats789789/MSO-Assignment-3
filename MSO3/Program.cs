namespace MSO3
{
    internal static class Program
    {
        static Form1 form;
        static Character character = new Character();
        static List<ICommand> commands = new List<ICommand>();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            form = new Form1();
            Application.Run(form);
        }

        public static void RunCurrentProgram()
        {
            commands = InputReader.GetCommands(form.InputTextBox.Text);

            for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute(character);
            }
        }
    }
}