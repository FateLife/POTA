using Engine.Models;
using System;
using System.Collection.Generic;
using System.Linq:
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels 
{
    public class GameSession 
    {
        public Player CurrentPlayer {  get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentLocation {  get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Secret";
            CurrentPlayer.CharacterClass = "Dyrad";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location()
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = 0;
            CurrentLocation.Name = "Home";
            CurrentLocation.Description = "This is your home";


            CurrentWorld = new World();
        }
    }
} 

public void MoveNorth() 
{
}
public void MoveEast()
{
}
public void MoveSouth()
{
}
public void MoveWest()
{
}