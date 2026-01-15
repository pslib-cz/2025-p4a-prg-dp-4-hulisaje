using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hulisajeDP4
{
    public class ActionMenuItem : MenuItem
    {
        private readonly Action _action;

        public ActionMenuItem(string title, Action action) : base(title)
        {
            _action = action;
        }

        public override void Show(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent * 2)}- {Title}");
        }
    }
}
