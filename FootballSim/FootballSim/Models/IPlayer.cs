namespace FootballSim.Models
{
    public interface IPlayer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IPosition Position { get; set; }
        ITeam Team { get; set; }
        string HomeTown { get; set; }
        string HomeState { get; set; }
    }
}