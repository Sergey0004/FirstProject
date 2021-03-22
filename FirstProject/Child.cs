using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Child : Parent
    {

        new public string GetColor()
        {
            return "Child color";
        }

        public override string Speak()
        {
            return "I'm a child";
        }
    }
}
