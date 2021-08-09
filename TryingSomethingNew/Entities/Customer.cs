using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Abstract;

namespace TryingSomethingNew.Entities
{
    public class Customer : IPerson
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public int DogumYili { get; set; }
        
    }
}
