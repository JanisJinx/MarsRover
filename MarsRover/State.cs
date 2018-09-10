namespace MarsRover
{
    public class State
    {
        public Position Position { get; set; }

        public  Orientation Orientation{ get; set; }

      

        public State(Position position, Orientation orientation)
        {
            Position = position;
            Orientation = orientation;
        }

        public override bool Equals(object obj)
        {
            return Position.X == ((State)obj).Position.X
                && Position.Y == ((State)obj).Position.Y
                && Orientation == ((State)obj).Orientation;
        }
    }
}