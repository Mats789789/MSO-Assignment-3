using System.Diagnostics;
using System.Numerics;
using System.Security.Policy;
using MSO3;

public class Character
{
    Point position;
    public Point Position => position;
    Direction direction;
    public Direction Direction => direction;
    public Tile[,]? grid;

    public bool OnBlockedTile => grid == null || grid[position.X, position.Y] == Tile.Blocked;
    public bool OffGrid =>
    grid == null ||
    position.X < 0 || position.Y < 0 ||
    position.X >= grid.GetLength(0) ||
    position.Y >= grid.GetLength(1);

    public Character(Character other)
    {
        this.position = other.position;
        this.direction = other.direction;
        this.grid = other.grid;
    }

    public Character() { }

    public void Move(int distance)
    {
        switch (direction)
        {
            case Direction.North: position.Y -= distance; break;
            case Direction.East: position.X += distance; break;
            case Direction.South: position.Y += distance; break;
            case Direction.West: position.X -= distance; break;
        }
    }

    public void Turn(string direction)
    {
        switch (direction)
        {
            case "right": this.direction = (Direction)(((int)this.direction + 1) % 4); break;
            case "left": this.direction = (Direction)(((int)this.direction + 3) % 4); break;
            default: break;
        }
    }

    public void Reset()
    {
        this.direction = Direction.North;
        this.position = new Point(0, 0);
    }
}

public enum Direction { North, East, South, West}
public enum Tile { Open, Blocked, EndState }
public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
