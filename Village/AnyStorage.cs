using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public enum Level { Small = 0, Middle, Big };
    [Serializable()]
    public class AnyStorage:AnyBuilding
    {
        private Level _level;
        public AnyStorage(string buildingName, int x_at, int y_at,Level level) : base(buildingName, x_at, y_at)
        {
            this._level = level;
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
            Game.Food += 250*(Convert.ToInt32( _level)+1);
        }
        public override void Cost()
        {
            Game.Money -= 1500 *Math.Pow((Convert.ToInt32(_level) + 1),1.2);
        }
        public override string CostAndProduction() { return "Production: Food " + (250*(Convert.ToInt32(_level)+1)).ToString()+ " per year.\r\n" + "Once only Cost Money: " + (1500 * Math.Pow((Convert.ToInt32(_level) + 1), 1.2)).ToString(); }

        public override string ToString()
        {
            return _buildingName + " is " + _level.ToString() + " in " + Position(); ;
        }
        public Level Level { get=>_level; set=> _level=value; }
        public override int x_pos { get => _x; set => _x = value; }
        public override int y_pos { get => _y; set => _y = value; }
      
        public override string name { get => _buildingName; set => _buildingName = value; }
    }
}
