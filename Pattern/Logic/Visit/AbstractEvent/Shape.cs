using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Visit.AbstractEvent
{
    public abstract class Shape
    {
        protected double area;
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public event EventHandler<ShapeEventArgs> ShapeChanged;
        public abstract void Draw();
        //The event-invoking method that derived classes can override.
        protected virtual void OnShapeChanged(ShapeEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<ShapeEventArgs> handler = ShapeChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
