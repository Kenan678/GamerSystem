using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class GamerManager : IGamerService
    {
       IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.validate(gamer)==true)
            {
                Console.WriteLine("kayit oldu");
            }
            else
            {
                Console.WriteLine("kayit yalns");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayit guncell");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayit silindi");
        }
    }
}
