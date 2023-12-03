using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    internal class Game
    {
        public Game() { }

        public void PlayGame(Control controller)
        {
            controller.goDown();
            controller.goUp();
            controller.goDown();
            controller.goLeft();
            controller.goRight();
        }
    }
}
