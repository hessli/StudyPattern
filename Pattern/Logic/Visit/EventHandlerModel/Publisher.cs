using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Visit.EventHandlerModel
{
   public class Publisher
    {
       public event EventHandler<CustomEventArgs> RaiseCustomEvent;

       public void DoSomething()
       {
           // Write some code that does something useful here
           // then raise the event. You can also raise an event
           // before you execute a block of code.
           OnRaiseCustomEvent(new CustomEventArgs("Did something"));

       }

       protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
       {
           EventHandler<CustomEventArgs> handler = RaiseCustomEvent;
           if (handler != null)
           {
               e.Msg += String.Format(" at {0}", DateTime.Now.ToString());
           }
           handler(this, e);
       
       }
    }
}
