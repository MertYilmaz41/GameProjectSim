using System;
using TryingSomethingNew.Abstract;
using TryingSomethingNew.Concrete;
using TryingSomethingNew.Entities;

namespace TryingSomethingNew
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson gamer2 = new Gamer();
            gamer2.DogumYili = 2003;
            gamer2.FirstName = "Melih";
            gamer2.LastName = "Küçük";
            gamer2.TcNo = "72946295";

            IPerson customer1 = new Customer();
            customer1.DogumYili = 2002;
            customer1.FirstName = "Salih";
            customer1.LastName = "Şimşek";
            customer1.TcNo="98765432";

            IPerson customer2 = new Customer();
            customer2.DogumYili = 2004;
            customer2.FirstName = "İlker";
            customer2.LastName = "Kaya";
            customer2.TcNo = "01285386";

            IGame game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "New World";
            game1.GamePrice = 110;

            IGame game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "Valorant";
            game2.GamePrice = 0;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.SignUp(new Gamer
            {
                DogumYili=2001, FirstName = "Mert", LastName="Akın", TcNo="12345678"

            });
        }
    }
}
