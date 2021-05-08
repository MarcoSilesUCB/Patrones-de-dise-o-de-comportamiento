using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DrinkEndState : IPersonState
    {
        public void HandleOperation(Person personContext)
        {
            Console.WriteLine("{0}: Person ends drinking water", nameof(DrinkStartState));
            personContext.PersonState = new ReadyState();
            personContext.PersonState.HandleOperation(personContext);
        }
    }
}
