using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( game.gameName + " game is added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.gameName + " game is deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.gameName + " game info is updated");
        }
    }
}
