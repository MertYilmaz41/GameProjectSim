using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Entities;

namespace TryingSomethingNew.Concrete
{
    public class GameManager
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName + " " + " adlı oyun başarıyla eklendi.");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName + " " + " adlı oyun başarıyla silindi.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + " " + " adlı oyun başarıyla güncellendi.");
        }
       
    }
}
