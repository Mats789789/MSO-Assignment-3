using System.Diagnostics;

namespace MSO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void runProgramButton_Click(object sender, EventArgs e)
        {
            Program.RunCurrentProgram();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = ExampleElements.basicProgram;
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = ExampleElements.advancedProgram;
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = expertToolStripMenuItem.Text;
        }

        private void filePathProgramInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string filePath = ((ToolStripTextBox)sender).Text;
                if (File.Exists(filePath))
                {
                    InputTextBox.Text = File.ReadAllText(filePath);
                }
            }
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadGrid(ExampleElements.threeBythree, programViewPanel);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadGrid(ExampleElements.fiveByfive, programViewPanel);
        }

        private void filePathGridInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string filePath = ((ToolStripTextBox)sender).Text;
                Program.LoadGrid(GridBuilder.GetGridFromTxt(filePath), programViewPanel);
            }
        }

        private void programViewPanel_Paint(object sender, PaintEventArgs e)
        {
            Tile[,]? grid = Program.currentGrid;

            if (grid?.Length > 0)
            {
                GridBuilder.DrawGrid(grid, e);
            }     
        }
    }
}
