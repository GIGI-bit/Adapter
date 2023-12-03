using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    internal class ControllerAdapter : Control
    {
        public Keyboard keyboard;
        public ControllerAdapter(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }
        public override void goRight()
        {
            keyboard.rightArrow();
        }
        public override void goLeft()
        {
            keyboard.leftArrow();
        }
        public override void goUp()
        {
            keyboard.upArrow();
        }
        public override void goDown()
        {
            keyboard.downArrow();
        }

    }
}
