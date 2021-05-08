using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DrinkingState : IPersonState
    {
        public void HandleOperation(Person personContext)
        {
            Console.WriteLine("{0}: Person is drinking water", nameof(DrinkStartState));
            personContext.PersonState = new DrinkEndState();
            personContext.PersonState.HandleOperation(personContext);
        }
    }
}
