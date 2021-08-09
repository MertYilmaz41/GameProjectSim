using System;
using System.Collections.Generic;
using System.Text;

namespace TryingSomethingNew.Abstract
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public int DogumYili { get; set; }
    }
}
