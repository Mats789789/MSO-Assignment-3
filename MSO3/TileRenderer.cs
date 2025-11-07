
namespace MSO3
{
    internal class TileRenderer
    {
        public static void DrawTile(Graphics g, Tile tile, int x, int y, int size)
        {
            //Fill basic tiles
            switch (tile)
            {
                case Tile.Blocked: g.FillRectangle(Brushes.Black, x, y, size, size); break;
                case Tile.EndState: g.FillRectangle(Brushes.Green, x, y, size, size); break;
                default: break;
            }

            //Draw borders
            g.DrawRectangle(Pens.Black, x, y, size, size);
        }

        public static void DrawImageTile(Graphics g, Image image, int x, int y, int size)
        {
            g.DrawImage(image, new Rectangle(x, y, size, size));
            g.DrawRectangle(Pens.Black, x, y, size, size);
        }
    }
}
