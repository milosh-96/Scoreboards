namespace Scoreboards.Data
{
    public abstract class Player
    {
        public int ShirtNumber { get; set; } = 0;
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";

        public string Position { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
