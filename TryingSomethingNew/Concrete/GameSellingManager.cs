using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Abstract;
using TryingSomethingNew.Entities;

namespace TryingSomethingNew.Concrete
{
    public class GameSellingManager : IGameSellingService
    {
        public void Sell()
        {
            Console.WriteLine("Oyun satıldı.");
        }
    }
}
