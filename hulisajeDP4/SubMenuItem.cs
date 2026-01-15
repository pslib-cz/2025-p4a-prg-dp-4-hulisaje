using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hulisajeDP4
{
    public class SubMenuItem : MenuItem
    {
        private readonly List<MenuItem> _children = new List<MenuItem>();

        public SubMenuItem(string title) : base(title) { }

        public void Add(MenuItem item)
        {
            _children.Add(item);
        }

        public override void Show(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent * 2)}+ {Title}");
            foreach (var child in _children)
            {
                child.Show(indent + 1);
            }
        }
    }
}
