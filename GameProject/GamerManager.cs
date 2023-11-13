using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
        //No class will be naked
        //When you see operation use interface at the beginning
        //Bir manager sınıfın içerisinde başka bir manager sınıfı kullanıcaksan asla onu newleme
        //onun yerine method injection yapıyoz işte aşağıdaki gibi Iuservalidationservice _uservalidationservice ile
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Signed up");

            }
            else
            {
                Console.WriteLine("We could not sign you up");

            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }
    }
}
