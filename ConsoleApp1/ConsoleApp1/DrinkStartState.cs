using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DrinkStartState : IPersonState
    {
        public void  HandleOperation(Person personContext)
        {
            Console.WriteLine("{0}: Person starts drinking water", nameof(DrinkStartState));
            personContext.PersonState = new DrinkingState();
            personContext.PersonState.HandleOperation(personContext);
        }
    }
}
