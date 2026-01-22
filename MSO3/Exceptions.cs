
namespace MSO3
{
    public class InvalidGridException : Exception
    {
        public InvalidGridException() : base ("Grid can not be null or contain invalid symbols") { }
    }

    public class InvalidMoveException : Exception
    {
        public InvalidMoveException() : base("Character cannot go off the grid or on a blocked tile") { }
    }

    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(int line) : base($"Invalid command on line {line}") { }
    }

    public class  FilePathNotFoundException : Exception
    {
        public FilePathNotFoundException() : base("Filepath could not be found") { }
    }
}
