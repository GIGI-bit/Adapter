using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    internal class Controller : Control
    {
        public Controller() { }
        public void goDown()
        {
            Console.WriteLine("Go Down");
        }

        public void goLeft()
        {
            Console.WriteLine("Go Left");
        }

        public void goRight()
        {
            Console.WriteLine("Go Right");
        }

        public void goUp()
        {
            Console.WriteLine("Go Up");
        }
    }
}
