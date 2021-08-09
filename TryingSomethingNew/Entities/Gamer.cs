using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Abstract;

namespace TryingSomethingNew.Entities
{
    public class Gamer : IPerson
    {
        public int GamerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo  { get; set; }
        public int DogumYili { get; set; }
     
    }
}
