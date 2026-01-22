using System.Diagnostics;
using MSO3;

public interface IProgramController
{
    void LoadGrid(Tile[,] grid, Panel gridPanel);
    void RunProgram(List<ICommand> commands, bool printMetrics);
    void TryRunProgram(List<ICommand> commands, bool printMetrics);
    void WarnUser(string message);
    void Reset(Panel gridPanel);
    Form1 Form { get; set; }
    Character Character { get; set; }
    GridBuilder GridBuilder { get; set; }
}

namespace MSO3
{
    public class Program : IProgramController
    {
        public Character Character { get; set; }
        public GridBuilder GridBuilder { get; set; }
        public Form1 Form { get; set; }
        private InputReader inputReader;

        public Program(Character character)
        {
            Character = character;
            GridBuilder = new GridBuilder(this);
            inputReader = new InputReader(this);
        }

        public static Tile[,]? programGrid;

        public void RunProgram(List<ICommand> commands, bool printMetrics)
        {
            //Clear warnings and reset character
            Character.Reset();
            Form.warningTextBox.Text = "";

            if (Character.grid == null) throw new InvalidGridException();

            string log = "";
            bool validTile = true;

            try
            {
                for (int i = 0; i < commands.Count; i++)
                {
                    commands[i].Execute(Character);
                    log += commands[i].LogExecute();

                    if (Character.OffGrid || Character.OnBlockedTile) // check if invalid move was made
                    {
                        // Warn user and stop moving the character
                        throw new InvalidMoveException();
                    }
                }
            }
            catch (InvalidMoveException e)
            {
                WarnUser(e.Message);
            }
            
            //Add metrics to the log textbox
            if (printMetrics) log += "\r\n\r\n" + GetMetrics(Form.inputTextBox.Text, log);
            Form.outPutTextBox.Text = log;
            
            commands.Clear();

            //Redraw character before termination
            Form.programViewPanel.Refresh();

            if (validTile && Character.OnEndStateTile)
            {
                Form.warningTextBox.Text = "You won! The character ended on the right tile.";
            }
        }

        public void TryRunProgram(List<ICommand> commands, bool printMetrics)
        {
            try
            {
                RunProgram(commands, printMetrics);
            }
            catch (InvalidGridException e)
            {
                WarnUser(e.Message);
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
            Form.warningTextBox.Text = "Warning: " + warning;
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
            Form.outPutTextBox.Text = "";
            Form.warningTextBox.Text = "";
        }

        public void AttachUI(Form1 form)
        {
            this.Form = form;
        }
    }
}