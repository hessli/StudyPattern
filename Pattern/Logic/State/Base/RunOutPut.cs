using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.State.Base
{
   public class RunOutPut
    {


       private static RunOutPut _instant;


       public static RunOutPut Instant {

           get {

               return _instant;
           }
       }

       static RunOutPut()
       {
           _instant = new RunOutPut();
       }
       RunOutPut()
       { }

       public void  RunBase()
       {
           Context context = new Context(new ConcreteStateA());
           context.Request();
           context.Request();
           context.Request();
       }
    }
}
