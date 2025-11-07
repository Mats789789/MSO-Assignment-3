using MSO3;

public interface IProgramController
{
    void LoadGrid(Tile[,] grid, Panel gridPanel);
    void RunProgram(bool printMetrics);
    void WarnUser(string message);
    void Reset(Panel gridPanel);
    Character Character { get; set; }
    GridBuilder GridBuilder { get; set; }
}

namespace MSO3
{
    internal class Program : IProgramController
    {
        public Character Character { get; set; }
        public GridBuilder GridBuilder { get; set; }
        private Form1 form;
        private InputReader inputReader;

        public Program(Character character)
        {
            Character = character;
            GridBuilder = new GridBuilder(this);
            inputReader = new InputReader(this);
        }

        static List<ICommand> commands = new List<ICommand>();
        public static Tile[,]? programGrid;

        public void RunProgram(bool printMetrics)
        {
            Character.Reset(); //
            form.warningTextBox.Text = "";

            if (Character.grid == null)
            {
                WarnUser("cannot run program without valid grid");
                return;
            }

            commands = inputReader.GetCommands(form.inputTextBox.Text);
            string log = "";
            bool validTile = true;

            for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute(Character);
                log += commands[i].LogExecute();

                if (Character.OffGrid || Character.OnBlockedTile) // check if invalid move was made
                {
                    WarnUser("character went to invalid square");
                    validTile = false;
                    break;
                }
            }

            if (printMetrics) log += "\r\n\r\n" + GetMetrics(form.inputTextBox.Text, log);

            form.outPutTextBox.Text = log;
            commands.Clear();

            //Draw character at termination
            form.programViewPanel.Refresh();

            if (validTile && Character.OnEndStateTile)
            {
                form.warningTextBox.Text = "You won! The character ended on the right tile.";
            }
        }

        private string GetMetrics(string inputText, string log)
        {
            var lines = InputReader.GetLinesTxt(inputText);
            
            int numberOfCommands = log.Split(',').Count() - 1;
            int maxNesting = Metrics.MaxNesting(lines);
            int numberOfRepeats = Metrics.NumberOfRepeats(lines);

            return 
                $"NumberOfCommands: {numberOfCommands}\r\nMaxNesting: {maxNesting}\r\nNumberOfRepeats: {numberOfRepeats}";
        }
        
        public void WarnUser(string warning)
        {
            form.warningTextBox.Text = "Warning: " + warning;
        }

        public void LoadGrid(Tile[,] grid, Panel gridPanel)
        {
            Character.Reset();
            programGrid = grid;
            Character.grid = grid; // set characters grid to the current grid
            gridPanel.Refresh();
        }

        public void Reset(Panel gridPanel)
        {
            Character.Reset();
            gridPanel.Refresh();
            form.outPutTextBox.Text = "";
            form.warningTextBox.Text = "";
        }

        public void AttachUI(Form1 form)
        {
            this.form = form;
        }
    }
}