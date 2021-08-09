using System;
using System.Collections.Generic;
using System.Text;

namespace TryingSomethingNew.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(IPerson person);
    }
}
