using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate_Pattern.Structural
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>

    public abstract class Decorate : Component
    {
        protected Component component;

        public void SetComponent(Component _component)
        {
            this.component = _component;
        }
        public override void Operation()
        {
            if(component != null)
            {
                component.Operation();
            }
        }
    }
}
