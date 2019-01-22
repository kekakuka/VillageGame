using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    [Serializable()]
    public abstract class AnyBuilding
    {
        protected string _buildingName;
        protected int _x;
        protected int _y;


        public bool HitTest(Point p)
        {
            GraphicsPath pth = new GraphicsPath();
            Rectangle rec = new Rectangle(_x, _y, 80, 80);           
            pth.AddRectangle(rec);
            bool retval = pth.IsVisible(p);
            pth.Dispose();
            return retval;
        }



        public AnyBuilding(string buildingName, int x_at, int y_at)
        {
            _buildingName = buildingName;
            _x = x_at;
            _y = y_at;
                  
        }
        public abstract void Display(Graphics g);
        public abstract void Produce();
        public abstract void Cost();
        public abstract string CostAndProduction();
        public string Position()  //non abstract method
        {
            return "(" + _x.ToString() + "," + _y.ToString() + ")";
        }

        public abstract int x_pos //abstract property
        {
            get;
            set;
        }

        public abstract int y_pos //abstract property
        {
            get;
            set;
        }

       
        public abstract string name //abstract property
        {
            get;
            set;
        }

    }
}
