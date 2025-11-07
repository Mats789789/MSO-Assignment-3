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
            InputTextBox.Text = advancedToolStripMenuItem.Text;
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = expertToolStripMenuItem.Text;
        }

        private void fromFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = fromFileToolStripMenuItem1.Text;
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadGrid(ExampleElements.threeBythree, programViewPanel);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadGrid(ExampleElements.fiveByfive, programViewPanel);
        }

        private void programViewPanel_Paint(object sender, PaintEventArgs e)
        {
            bool[,]? grid = Program.currentGrid;

            if (grid?.Length > 0)
                GridBuilder.DrawGrid(grid, e);
        }

    }
}
