using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private IPersonState _personState;

        public Person()
        {
            _personState = new ReadyState();
        }
        public IPersonState PersonState
        {
            get
            {
                return _personState;
            }
            set
            {
                _personState = value;
            }
        }

        public void Drink()
        {
            Console.WriteLine("Drink procces begins");
            _personState = new DrinkStartState();
            _personState.HandleOperation(this);
        }
    }
}
