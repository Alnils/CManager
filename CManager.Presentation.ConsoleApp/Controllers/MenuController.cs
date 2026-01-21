using CManager.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Presentation.ConsoleApp.Controllers
{
    internal class MenuController
    {
        
        public MenuController(ICustomerService customerService) {}

        public void Run() 
        {
            Console.WriteLine("hej from controller");
        }
    }
}
