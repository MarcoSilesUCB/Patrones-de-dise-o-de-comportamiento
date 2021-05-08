using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IPersonState
    {
        void HandleOperation(Person personContext);
    }
}
