using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_List_app
{
    class List_Items
    {
        private String Item;

        public List_Items(string item)
        {
            Item = item;
        }

        public string Item1 { get => Item; set => Item = value; }
    }
}
