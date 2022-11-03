using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class UserValidationManager : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            if (gamer.BirthDate==1985 && gamer.FirstName=="engin"&& gamer.LastName=="demirog"
                &&gamer.IdentityNumber==12345)
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
