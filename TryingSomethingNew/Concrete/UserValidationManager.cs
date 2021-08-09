using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Abstract;

namespace TryingSomethingNew.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(IPerson person)
        {
            if (person.DogumYili == 2001 && person.FirstName == "Mert" && person.LastName == "Akın" && person.TcNo == "12345678")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
