using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hulisajeDP4
{
    public abstract class MenuItem
    {
        public string Title { get; set; }

        protected MenuItem(string title)
        {
            Title = title;
        }

        public abstract void Show(int indent = 0);
    }
}
