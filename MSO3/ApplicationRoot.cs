
using System.Diagnostics;

namespace MSO3
{
    internal static class ApplicationRoot
    {
        static Program program;
        static Form1 form;
        public static Character character;
        //static List<ICommand> commands = new List<ICommand>();
        //public static Tile[,]? currentGrid;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            character = new Character();
            program = new Program(character);
            form = new Form1(program);
            program.AttachUI(form);
            Application.Run(form);
        }
    }
}
