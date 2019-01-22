using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village
{
    public partial class ViewForm3 : Form, IBuildingViews
    {
        private BuildingsModel myModel;
        public BuildingsModel MyModel
        {
            set
            {
                myModel = value;
            }
        }
        public ViewForm3()
        {
            InitializeComponent();
          //  this.cbSelect.SelectedIndex = 0;
          
        }

        public void RefreshViews()
        {
            clearPanel();
            // create arrayList from model and convert to array of Buildings
            List<AnyBuilding> theBuildingList = myModel.AnyBuildings;                               
            Graphics g = this.pnlDrawOn.CreateGraphics();
            // draw all Buildings in array
            foreach (AnyBuilding b in theBuildingList)
            {
                if (cbSelect.SelectedIndex == 0)
                {
                    b.Display(g);
                }
                else if (cbSelect.SelectedIndex == 1&&b.name=="Castle")
                {
                    b.Display(g);
                }
                else if (cbSelect.SelectedIndex == 2 && b.name == "Storage")
                {
                    b.Display(g);
                }
                else if (cbSelect.SelectedIndex == 3 && b.name == "Training")
                {
                    b.Display(g);
                }
               
            }
        }

        private void clearPanel()
        {
            pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  if (myModel!=null)
          //  {
                RefreshViews();
          //  }
          
        }

        private void ViewForm3_Load(object sender, EventArgs e)
        {

        }
    }
}
