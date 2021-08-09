using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Abstract;
using TryingSomethingNew.Entities;

namespace TryingSomethingNew.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void SignUp(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Doğrulama başarılı.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }

            Console.WriteLine("Oyuncunun hesabı başarıyla kayıt edildi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncunun hesabı başarıyla güncellendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncunun hesabı başarıyla silindi.");
        }
    }
}
