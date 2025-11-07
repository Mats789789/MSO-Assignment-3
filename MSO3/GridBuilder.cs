using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace MSO3
{
    internal class GridBuilder
    {
        public static bool[,] GetGridFromTxt(string path)
        {
            if (File.Exists(path))
            {
                List<string> lines = File.ReadAllLines(path).ToList();
                return BuildGrid(lines);
            }
            else
            {
                Program.WarnUser("file path could not be found");
                return Program.currentGrid;
            }
        }

        public static bool[,] BuildGrid(List<string> lines)
        {
            int height = lines.Count;
            int width;

            if (height > 0) 
                width = lines.Max(l => l.Length);
            else 
                width = 0;

            bool[,] grid = new bool[height, width];

            for (int i = 0; i < height; i++)
            {
                string line = lines[i];

                for (int j = 0; j < width; j++)
                {
                    char c = line[j];

                    grid[i, j] = c switch
                    {
                        'x' => false,
                        'o' => true,
                        _ => throw new NotImplementedException()
                    };
                }
            }

            return grid;
        }

        public static void DrawGrid(bool[,] grid, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int height = grid.GetLength(0);
            int width = grid.GetLength(1);
            int cellSize = 250 / int.Max(height, width);
            int offsetX = (e.ClipRectangle.Width - width * cellSize) / 2;
            int offsetY = (e.ClipRectangle.Height - height * cellSize) / 2;

            Pen pen = new Pen(Color.Black);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++) 
                {
                    int x = j * cellSize + offsetX;
                    int y = i * cellSize + offsetY;
                    g.DrawRectangle(pen, new Rectangle(x, y, cellSize, cellSize));
                    
                    if (!grid[i, j])
                    {
                        g.FillRectangle(Brushes.Black, x, y, cellSize, cellSize);
                    }
                }
            }
            pen.Dispose();
        }
    }
}
