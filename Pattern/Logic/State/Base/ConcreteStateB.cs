using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.State.Base
{
    public class ConcreteStateB:State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("当前状态是 B.");
            context.State = new ConcreteStateA();
        }
    }
}
