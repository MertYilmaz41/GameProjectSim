using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Abstract;

namespace TryingSomethingNew.Entities
{
    public class Game : IGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
