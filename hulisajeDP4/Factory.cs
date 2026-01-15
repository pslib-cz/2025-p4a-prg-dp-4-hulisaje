using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hulisajeDP4
{
    public abstract class MenuFactory
    {
        public abstract MenuItem CreateMenuItem(string title, Action action = null);
    }

    public class ConcreteMenuFactory : MenuFactory
    {
        public override MenuItem CreateMenuItem(string title, Action action = null)
        {
            if (action != null)
                return new ActionMenuItem(title, action);
            else
                return new SubMenuItem(title);
        }
    }
}
