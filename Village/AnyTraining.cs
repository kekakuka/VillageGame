using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    [Serializable()]
    public class AnyTraining : AnyBuilding
    {
        private int _capacity;
        public AnyTraining(string buildingName, int x_at, int y_at, int capacity) : base(buildingName, x_at, y_at)
        {
            _capacity = capacity;
        }

        public override void Display(Graphics g)
        {
            if (g != null)
            {
                string _image = @".\Images\" + _buildingName + ".png";
                Image image = new Bitmap(_image);
                g.DrawImage(image, _x, _y, 80, 80);

            }
        }
        public override void Produce()
        {
            Game.Warriors += _capacity;
        }

        public override void Cost()
        {
            Game.Money -= 1500 * Math.Pow((_capacity / 50.0), 1.15);
        }
        public override string CostAndProduction()
        {
            double aaa = Math.Pow((_capacity / 50.0), 1.15);
            return "Training: Warriors " + (_capacity).ToString() + " per year.\r\n" + "Once only Cost Money: " + (1500 * aaa).ToString();
        }
        public override string ToString()
        {
            return _buildingName + " has " + _capacity.ToString() + " Capacity in " + Position(); ;
        }
        public int Capacity { get => _capacity; set => _capacity = value; }
        public override int x_pos { get => _x; set => _x = value; }
        public override int y_pos { get => _y; set => _y = value; }
        public override string name { get => _buildingName; set => _buildingName = value; }

    }
}
