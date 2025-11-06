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
            InputTextBox.Text = basicToolStripMenuItem.Text;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            bool[,] grid = GridBuilder.GetGridFromTxt("/Users/Matse/Desktop/TestGrid.txt");

            if (grid.Length > 0)
                GridBuilder.DrawGrid(grid, e);
            else
                throw new NotImplementedException(); // MAAAAAAAAAAAAAAAAAAAAAAAAAATS
        }
    }
}
