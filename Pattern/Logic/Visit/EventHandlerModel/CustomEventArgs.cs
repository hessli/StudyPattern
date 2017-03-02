using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Visit.EventHandlerModel
{
   public class CustomEventArgs
    {

       private string _msg;
       public CustomEventArgs(string s) {

           _msg = s;
       }

       public string Msg {

           get {

               return _msg;
           }
           set {
               _msg = value;
           }
       }
    }
}
