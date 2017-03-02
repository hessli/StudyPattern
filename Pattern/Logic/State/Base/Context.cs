using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.State.Base
{
   public class Context
    {
       private State state;
       public Context(State state)
       {
           this.state = state;
       }
       public State State
       {
           get { return state; }
           set { state = value; }
       }
       public void Request()
       {
           state.Handle(this);
       }
    }
}
