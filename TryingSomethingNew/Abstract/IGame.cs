using System;
using System.Collections.Generic;
using System.Text;

namespace TryingSomethingNew.Abstract
{
    public interface IGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
