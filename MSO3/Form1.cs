using System.Diagnostics;

namespace MSO3
{
    public partial class Form1 : Form
    {
        private readonly IProgramController program;

        public Form1(IProgramController programController)
        {
            InitializeComponent();
            this.program = programController;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void runProgramButton_Click(object sender, EventArgs e)
        {
            program.RunProgram(false);
        }

        private void metrics_button_Click(object sender, EventArgs e)
        {
            program.RunProgram(true);
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            program.Reset(programViewPanel);
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = ExampleElements.basicProgram;
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = ExampleElements.advancedProgram;
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = expertToolStripMenuItem.Text;
        }

        private void filePathProgramInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string filePath = ((ToolStripTextBox)sender).Text;
                if (File.Exists(filePath))
                {
                    inputTextBox.Text = File.ReadAllText(filePath);
                }
            }
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.LoadGrid(ExampleElements.threeBythree, programViewPanel);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.LoadGrid(ExampleElements.fiveByfive, programViewPanel);
        }

        private void filePathGridInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string filePath = ((ToolStripTextBox)sender).Text;
                program.LoadGrid(program.GridBuilder.GetGridFromTxt(filePath), programViewPanel);
            }
        }

        private void programViewPanel_Paint(object sender, PaintEventArgs e)
        {
            Tile[,]? grid = Program.programGrid;

            if (grid?.Length > 0)
                GridBuilder.DrawGrid(grid, e, program.Character.Position);
        }
    }
}
