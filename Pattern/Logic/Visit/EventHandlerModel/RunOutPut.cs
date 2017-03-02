using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Visit.EventHandlerModel
{
   public class RunOutPut
    {
       public void Run() {

           Publisher pub = new Publisher();
           Subscriber sub1 = new Subscriber("sub1", pub);
           Subscriber sub2 = new Subscriber("sub2", pub);
           pub.DoSomething();
           Console.WriteLine("Press Enter to close this window.");
           Console.ReadLine();

       }
    }
}
