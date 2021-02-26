using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManage : IGamerService
    {
        IUserValidationService _customerCheckService;

        public GamerManage(IUserValidationService userValidationService)
        {
            _customerCheckService = userValidationService;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.gamerName + " " + gamer.gamerSurname +" is deleted");
        }
        public void Registry(Gamer gamer)
        {
            if (_customerCheckService.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.gamerName + " " + gamer.gamerSurname + "is added");
            }
            else
            {
                throw new Exception("Not a real person");
            }
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Informations of " + gamer.gamerName + " " + gamer.gamerSurname + " is updated");
        }
    }
}
