using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Parent
    {
        public int myPublickIntParent;

        private readonly int _myPriveteIntParent;
        public string myString = "Test string in parent";
        protected int myProtectedIntPerent;

        public string GetColor()
        {
            return "Perent color";
        }

        public virtual string Speak()
        {
            return "I'm a perent";
        }
    }

    }

