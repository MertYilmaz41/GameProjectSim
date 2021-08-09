using System;
using System.Collections.Generic;
using System.Text;
using TryingSomethingNew.Entities;

namespace TryingSomethingNew.Abstract
{
    public interface IGamerService
    {
        void SignUp(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
