using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public interface IUserValidationService
    {
        bool validate( Gamer gamer);
    }
}
