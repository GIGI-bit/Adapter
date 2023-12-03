using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interfaces
{
    internal class Control
    {
        public Control() { }
        public virtual void goUp() { }
        public virtual void goDown() { }
        public virtual void goLeft() { }
        public virtual void goRight() { }
    }
}
