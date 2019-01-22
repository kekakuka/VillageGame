using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village
{
    public partial class ViewForm1 : Form, IBuildingViews
    {
        private BuildingsModel myModel;
        BinaryFormatter binFor;
        public BuildingsModel MyModel
        {
            set
            {
                myModel = value;
            }
        }
        public ViewForm1()
        {
            InitializeComponent();
            this.cbStorage.SelectedIndex = 0;
            cbStorage.Enabled = false;
            txtTraining.Enabled = false;
        }



        public void RefreshViews()
        {
            
            // clear drawOn panel
            lstBuildings.Items.Clear();
            // create arrayList from model and convert to array of Buildings
            List<AnyBuilding> theBuildingList = myModel.AnyBuildings;

            Graphics g = this.pnlDrawOn.CreateGraphics();
            // draw all Buildings in array
          
                foreach (AnyBuilding b in theBuildingList)
                {

                    lstBuildings.Items.Add(b.ToString());
                }

            
          
        }

        private void clearPanel()
        {
            pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int X, Y;
            AnyBuilding aBuilding;
            try
            {


                X = Convert.ToInt32(txtX.Text);
                Y = Convert.ToInt32(txtY.Text);

                // if circle selected create circle Building
                if (rbCastle.Checked)
                {
                    double defence = tbCastle.Value * 0.1 + 1;
                    aBuilding = new AnyCastle("Castle", X, Y, defence);
                }

                // if square selected create square Building
                else if (rbStorage.Checked)
                {
                    Level level = (Level)cbStorage.SelectedIndex;
                    aBuilding = new AnyStorage("Storage", X, Y, level);

                }

                else // must be an ellipse
                {
                    int capacity = Convert.ToInt32(txtTraining.Text);
                    aBuilding = new AnyTraining("Training", X, Y, capacity);

                }
                myModel.AddBuilding(aBuilding);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = lstBuildings.SelectedIndex;
            if (lstBuildings.SelectedIndex > -1)
            {
                if (myModel.AnyBuildings[n].name == "Castle")
                {
                    rbCastle.Checked = true;
                    tbCastle.Value = (int)Math.Round(((((AnyCastle)myModel.AnyBuildings[n]).Defence - 1) * 10));

                }
                else if (myModel.AnyBuildings[n].name == "Storage")
                {
                    rbStorage.Checked = true;
                    cbStorage.SelectedIndex = (int)((AnyStorage)myModel.AnyBuildings[n]).Level;

                }
                else
                {
                    rbTraining.Checked = true;
                    txtTraining.Value = ((AnyTraining)myModel.AnyBuildings[n]).Capacity;

                }
                txtX.Value = myModel.AnyBuildings[n].x_pos;
                txtY.Value = myModel.AnyBuildings[n].y_pos;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstBuildings.SelectedIndex > -1)
            {
                int n = lstBuildings.SelectedIndex;
                int X, Y;
                AnyBuilding aBuilding;
                try
                {


                    X = Convert.ToInt32(txtX.Text);
                    Y = Convert.ToInt32(txtY.Text);

                    // if circle selected create circle Building
                    if (rbCastle.Checked)
                    {
                        double defence = tbCastle.Value * 0.1 + 1;
                        aBuilding = new AnyCastle("Castle", X, Y, defence);


                    }

                    // if square selected create square Building
                    else if (rbStorage.Checked)
                    {
                        Level level = (Level)cbStorage.SelectedIndex;
                        aBuilding = new AnyStorage("Storage", X, Y, level);

                    }

                    else // must be an ellipse
                    {
                        int capacity = Convert.ToInt32(txtTraining.Text);
                        aBuilding = new AnyTraining("Training", X, Y, capacity);

                    }

                    myModel.UpdateBuilding(aBuilding, n);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an building");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBuildings.SelectedIndex > -1)
            {
                int n = lstBuildings.SelectedIndex;                          
                try
                {
                    myModel.DeleteBuilding(myModel.AnyBuildings[n]);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an building");
            }
        }

        private void rbStorage_CheckedChanged(object sender, EventArgs e)
        {
            tbCastle.Enabled = false;
            cbStorage.Enabled = true;
            txtTraining.Enabled = false;
        }

        private void rbTraining_CheckedChanged(object sender, EventArgs e)
        {
           
            tbCastle.Enabled = false;
            cbStorage.Enabled = false;
            txtTraining.Enabled = true;
        }

        private void rbCastle_CheckedChanged(object sender, EventArgs e)
        {
          
            tbCastle.Enabled = true;
            cbStorage.Enabled = false;
            txtTraining.Enabled = false;
        }

        private void ViewForm1_Load(object sender, EventArgs e)
        {
            binFor = new BinaryFormatter();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            myModel.AnyBuildings.Clear();
           
            myModel.UpdateViews();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myModel.AnyBuildings.Clear();
                FileInfo finfo = new FileInfo(openFileDialog1.FileName);
                Stream stream = finfo.Open(FileMode.Open);
                while (stream.Position != stream.Length)
                {
                    myModel.AnyBuildings.Add((AnyBuilding)binFor.Deserialize(stream));
                }
                stream.Close();
                this.Invalidate();
            }
           
            myModel.UpdateViews();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo finfo = new FileInfo(saveFileDialog1.FileName);
                Stream stream;
                stream = finfo.Open(FileMode.Create, FileAccess.ReadWrite);
                List<AnyBuilding> theBuildingList = myModel.AnyBuildings;
                foreach (AnyBuilding item in theBuildingList)
                {
                    binFor.Serialize(stream, item);
                }
                stream.Close();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
