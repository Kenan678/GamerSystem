using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            return true;    
        }
    }
}
