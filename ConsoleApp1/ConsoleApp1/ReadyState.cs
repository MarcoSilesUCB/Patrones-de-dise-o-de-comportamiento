using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ReadyState : IPersonState
    {
        public void HandleOperation(Person personContext)
        {
            Console.WriteLine("the glass of water and person are Ready to Drink again.");
        }
    }
}
