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
    public class AnyCastle:AnyBuilding
    {
       private double _defence;
        public AnyCastle(string buildingName, int x_at, int y_at, double defence) : base(buildingName, x_at, y_at)
        {
            this._defence = defence;
        }
        public double Defence { get => _defence; set => _defence = value; }

        public override void Display(Graphics g)
        {
            if (g != null)
            {
                string _image = @".\Images\" + _buildingName + ".png";
                Image image = new Bitmap(_image);
            
                g.DrawImage(image,_x,_y, 80, 80);

            }
        }

        public override void Produce() {
            Game.Money += 1200;
        }

        public override void Cost()
        {
            Game.Money -= 2500*_defence * _defence;
        }
        public override string CostAndProduction() { return "Production: Money " + 1200.ToString() + " per year.\r\n" + "Once only Cost Money: " + (2500 * _defence * _defence).ToString(); }
        public override string ToString()
        {
            return _buildingName+" has " + _defence.ToString() + " DFC in "+ Position(); ;
        }
       
        public override int x_pos { get => _x; set => _x=value; }
        public override int y_pos { get => _y; set => _y = value; }
        public override string name { get => _buildingName; set => _buildingName = value; }
    }
}
