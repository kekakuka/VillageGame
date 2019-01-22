using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village
{

    public partial class ViewForm2 : Form, IBuildingViews
    {
        private BuildingsModel myModel;
        AnyBuilding topBuilding; //  variable for selected Building
        int topBuildingIndex;
        bool dragging;
        Point lastPosition = new Point(0, 0);
        Point currentPosition = new Point(0, 0);
        BinaryFormatter binFor;
        Graphics g;
        int years = 0;
        bool gameOver = false;
        Thread th;
        public BuildingsModel MyModel
        {
            set
            {
                myModel = value;
            }
        }
        public ViewForm2()
        {
            InitializeComponent();
            
        }




        public void RefreshViews()
        {
            clearPanel();
            // create arrayList from model and convert to array of Buildings
            List<AnyBuilding> theBuildingList = myModel.AnyBuildings;
            g = this.pnlDrawOn.CreateGraphics();
            Image image = new Bitmap(@".\Images\ground.png");
            g.DrawImage(image, 0, 0);
            if (theBuildingList.Count == 0)
            {
                topBuilding = null;
            }
            else
            {
                foreach (AnyBuilding b in theBuildingList)
                {
                    b.Display(g);
                }
                if (topBuilding != null)
                {
                    lblBuildingInfo.Text = topBuilding.CostAndProduction();
                    Rectangle rec = new Rectangle(topBuilding.x_pos, topBuilding.y_pos, 80, 80);
                    g.DrawRectangle(new Pen(Color.Red), rec);
                }
            }
            // draw all Buildings in array

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
                    myModel.AddBuilding(aBuilding);
                }

                // if square selected create square Building
                else if (rbStorage.Checked)
                {
                    Level level = (Level)cbStorage.SelectedIndex;
                    aBuilding = new AnyStorage("Storage", X, Y, level);
                    myModel.AddBuilding(aBuilding);
                }

                else // must be an ellipse
                {
                    int capacity = Convert.ToInt32(txtTraining.Text);
                    aBuilding = new AnyTraining("Training", X, Y, capacity);
                    myModel.AddBuilding(aBuilding);
                }
                topBuilding = aBuilding;
                lblBuildingInfo.Text = topBuilding.CostAndProduction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbCastle_CheckedChanged(object sender, EventArgs e)
        {
            tbCastle.Enabled = true;
            cbStorage.Enabled = false;
            txtTraining.Enabled = false;
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            int X, Y;
            AnyBuilding aBuilding;
            if (topBuilding != null)
            {
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

                    myModel.UpdateBuilding(aBuilding, topBuildingIndex);
                    topBuilding = aBuilding;
                    lblBuildingInfo.Text = topBuilding.CostAndProduction();

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
                MessageBox.Show("Please select an building!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (topBuilding != null)
            {
                try
                {
                    myModel.DeleteBuilding(myModel.AnyBuildings[topBuildingIndex]);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                topBuilding = null;
            }
            else
            {
                MessageBox.Show("Please select an building!");
            }
        }

        private void pnlDrawOn_MouseDown(object sender, MouseEventArgs e)
        {
            List<AnyBuilding> theBuildingList = myModel.AnyBuildings;
            // loop through array checking if mouse is over Building
            tmReDrawn.Interval = 500;
            int countIndex = 0;
            foreach (AnyBuilding s in theBuildingList)
            {

                if (s.HitTest(new Point(e.X, e.Y)))
                {
                    topBuildingIndex = countIndex;
                    // if so make Building topBuilding
                    topBuilding = s;
                }
                countIndex++;
                if (topBuilding != null) // if there is a topBuilding
                {
                    if (topBuilding.name == "Castle")
                    {
                        rbCastle.Checked = true;
                        tbCastle.Value = (int)Math.Round(((((AnyCastle)topBuilding).Defence - 1) * 10));

                    }
                    else if (topBuilding.name == "Storage")
                    {
                        rbStorage.Checked = true;
                        cbStorage.SelectedIndex = (int)((AnyStorage)topBuilding).Level;

                    }
                    else
                    {
                        rbTraining.Checked = true;
                        txtTraining.Value = ((AnyTraining)topBuilding).Capacity;
                    }
                }
                // reset position of selected Building by value of mouse move 
            }
            if (topBuilding != null)
            {
                g = this.pnlDrawOn.CreateGraphics();
                txtX.Value = topBuilding.x_pos;
                txtY.Value = topBuilding.y_pos;
                Rectangle rec = new Rectangle(topBuilding.x_pos, topBuilding.y_pos, 80, 80);
                g.DrawRectangle(new Pen(Color.Red), rec);
                dragging = true;


            }
        }

        private void pnlDrawOn_MouseMove(object sender, MouseEventArgs e)
        {  
            // set last position to current position
            lastPosition = currentPosition;
            // set current position to mouse position
            currentPosition = new Point(e.X, e.Y);
            // calculate how far mouse has moved 
            int xMove = currentPosition.X - lastPosition.X;
            int yMove = currentPosition.Y - lastPosition.Y;

            if (dragging) // mouse is down 
            {
                if (topBuilding != null) // if there is a topBuilding
                {
                    if (topBuilding.name == "Castle")
                    {
                        rbCastle.Checked = true;
                        tbCastle.Value = (int)Math.Round(((((AnyCastle)topBuilding).Defence - 1) * 10));

                    }
                    else if (topBuilding.name == "Storage")
                    {
                        rbStorage.Checked = true;
                        cbStorage.SelectedIndex = (int)((AnyStorage)topBuilding).Level;

                    }
                    else
                    {
                        rbTraining.Checked = true;
                        txtTraining.Value = ((AnyTraining)topBuilding).Capacity;

                    }
                    txtX.Value = topBuilding.x_pos;
                    txtY.Value = topBuilding.y_pos;
                    topBuilding.Display(g);
                }
                // reset position of selected Building by value of mouse move 
                if (topBuilding.x_pos + xMove <= 500 && topBuilding.x_pos + xMove >= 0)
                {
                    topBuilding.x_pos = topBuilding.x_pos + xMove;
                }
                if (topBuilding.y_pos + yMove <= 300 && topBuilding.y_pos + yMove >= 0)
                {
                    topBuilding.y_pos = topBuilding.y_pos + yMove;
                }
            }
        }

        private void pnlDrawOn_MouseUp(object sender, MouseEventArgs e)
        {
            tmReDrawn.Interval = 5000;
            dragging = false;
            // clear drawOn panel  
            myModel.UpdateViews();
        }

        private void tmReDrawn_Tick(object sender, EventArgs e)
        {
            RefreshViews();
        }



        private void ViewForm2_Load(object sender, EventArgs e)
        {
            this.cbStorage.SelectedIndex = 0;
            cbStorage.Enabled = false;
            txtTraining.Enabled = false;
            binFor = new BinaryFormatter();
            Control.CheckForIllegalCrossThreadCalls = false;
            btnEnd.Enabled = false;
            RefreshViews();
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myModel.AnyBuildings.Clear();
            topBuilding = null;
            myModel.UpdateViews();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
            topBuilding = null;
            myModel.UpdateViews();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void eixtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (th!=null)
            {
                th.Abort();
            }
            th = new Thread(PlayGame);
            th.IsBackground = true;
            th.Start();
            if (gameOver==true)
            {
                btnPlay.Text = "Play game";
            }
           
        }

        public void PlayGame() {
            topBuilding = null;
            List<AnyBuilding> theBuildingList = myModel.AnyBuildings;
            btnPlay.Text = "Click to pass one year";

            if (years == 0)
            {
                btnEnd.Enabled = true;
               // Application.OpenForms["ViewForm1"].Hide();             
                gameOver = false;
                pnlDrawOn.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
                menuStrip1.Enabled = false;
                tmReDrawn.Interval = 1000000;
                Game.Food = 0;
                Game.Money = 0;
                Game.Warriors = 0;
                foreach (AnyBuilding item in theBuildingList)
                {
                    item.Cost();
                }
                foreach (AnyBuilding item in theBuildingList)
                {
                    item.Produce();
                }
                for (int j = 0; j <myModel.AnyBuildings.Count; j++)
                {
                    if (gameOver==true)
                    {
                        break;
                    }
                    for (int k = j+1; k < myModel.AnyBuildings.Count; k++)
                    {
                        if (Math.Abs((myModel.AnyBuildings[j].x_pos - myModel.AnyBuildings[k].x_pos))<69&& Math.Abs((myModel.AnyBuildings[j].y_pos - myModel.AnyBuildings[k].y_pos)) < 69)
                        {
                            gameOver = true;
                            MessageBox.Show("One of the building is covering another building ,you lose!");
                            break;
                        }  
                    }
                }
            }
            else
            {
                foreach (AnyBuilding item in theBuildingList)
                {
                    item.Produce();
                }

            }

            //  PassOneYear(years);
            double defences = 1;
            Game.Food -= Game.Warriors;

            foreach (var item in myModel.AnyBuildings)
            {
                if (item.name == "Castle")
                {
                    defences +=((AnyCastle)item).Defence-1;
                }
            }

            double enemies = 100 / defences;
            enemies *= Math.Pow(1.33, years);
           
            if (years < 5) {
                enemies = enemies / 50;
            }
            Game.Warriors -= enemies;
            txtGame.Text = "";
            if (Game.Food < 0)
            {
                Game.Warriors += Game.Food;
                txtGame.Text += "The Warriors feel hungry! " + "\r\n" + (-Game.Food).ToString("#0") + " Warriors dead" + "\r\n";
                Game.Food = 0;
            }
            if (years > 7)
            {
                Game.Warriors += Game.Money / 200;
                Game.Food += Game.Money / 50;

                txtGame.Text += "You spend all your money to buy " + (Game.Money / 50).ToString() + " food and training " + (Game.Money / 200).ToString("#0") + " warriors" + "\r\n";
                Game.Money = 0;
            }
            txtGame.Text += "Money: " + Game.Money.ToString() + "\r\n";
            txtGame.Text += "Food: " + Game.Food.ToString() + "\r\n";
            txtGame.Text += "Warriors: " + Game.Warriors.ToString("#0") + "\r\n";
            txtGame.Text += "Years: " + (years + 1).ToString() + "\r\n";
            txtGame.Text += "Denfence: " + (defences).ToString() + "\r\n";
            txtGame.Text += "Enemies: " + enemies.ToString("#0") + "\r\n";
            if (years == 7 && Game.Money < 0)
            {
                gameOver = true;
                
               
            }
            if (Game.Warriors < 0)
            {
                gameOver = true;
              
            }
            Bitmap animatedGif = new Bitmap(@".\Images\war.gif");

            // A Gif image's frame delays are contained in a byte array

            // in the image's PropertyTagFrameDelay Property Item's

            // value property.

            // Retrieve the byte array...

            int PropertyTagFrameDelay = 0x5100;

            PropertyItem propItem = animatedGif.GetPropertyItem(PropertyTagFrameDelay);

            byte[] bytes = propItem.Value;

            // Get the frame count for the Gif...

            FrameDimension frameDimension = new FrameDimension(animatedGif.FrameDimensionsList[0]);

            int frameCount = animatedGif.GetFrameCount(FrameDimension.Time);

            // Create an array of integers to contain the delays,

            // in hundredths of a second, between each frame in the Gif image.


        

            Graphics ga = pnlDrawOn.CreateGraphics();

           

            years++;

            if (gameOver == true)
            {
                Application.OpenForms["ViewForm1"].Show();           
                txtGame.Text = "How to play the game? Defend Your village!" + "\r\n";
                txtGame.Text += "1.Add or modify buildings for your village." + "\r\n";
                txtGame.Text += "2.Click play game.And then click again to pass one year." + "\r\n";
                txtGame.Text += "3.Cannot modify anything during the game." + "\r\n";
                txtGame.Text += "Rules: " + "\r\n";
                txtGame.Text += "1.Each building cannot cover other buildings.Otherwise you will lose." + "\r\n";
                txtGame.Text += "2.All building will cost money once when you start game. After 7 years the money must more than 0. Otherwise you will lose." + "\r\n";
                txtGame.Text += "3.Every year the enemy will attack your village.Some warriors will be dead in the war.When no warriors to protect your village you will lose." + "\r\n";
                txtGame.Text += "4.A warrior cost one food per year.When food is not enough some warriors will be dead." + "\r\n";
                txtGame.Text += "5.The castle will produce money and add the defence for the village." + "\r\n";
                txtGame.Text += "6.The training ground will train your warriors." + "\r\n";
                txtGame.Text += "7.The storage will produce food." + "\r\n";
                txtGame.Text += "8.Try to be survived." + "\r\n";
                txtGame.Text += "Poor:0-7; Medium:8-13; Good:14-17; Nice:19-23; Great:23+" + "\r\n";
                this.Hide();
                this.Show();
                if (years == 8 && Game.Money < 0)
                {
                   
                    MessageBox.Show("The creditor is asking for his money.You lose!!You money less than 0 in the 7 year!");

                }
                if (Game.Warriors < 0)
                {
                    MessageBox.Show("Your village is destroyed by " + enemies.ToString("#0") + " enemies.You lose!! Your village survived for " + years.ToString() + " years");

                }
                years = 0;
                pnlDrawOn.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
                menuStrip1.Enabled = true;
                tmReDrawn.Interval = 5000;
                
              
                RefreshViews();
               
                    btnPlay.Text = "Play game";
               
                th.Abort();
            }
           
                while (true)
                {
                    for (int i = 0; i <= animatedGif.GetFrameCount(frameDimension) - 1; i++)

                    {

                        animatedGif.SelectActiveFrame(frameDimension, i);

                        ga.DrawImage(animatedGif, 0, 0, 700, 400);

                        Application.DoEvents();

                        //    Thread.Sleep(delays[i] * 10);

                    }
                }
            
          

        }
       

        private void ViewForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th!=null)
            {
                th.Abort();
            }
          
           
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            gameOver = true;
            if (th != null)
            {
                th.Abort();
            }
            th = new Thread(PlayGame);
            th.IsBackground = true;
            th.Start();
            if (gameOver == true)
            {              
                btnPlay.Text = "Play game";
            }
            btnEnd.Enabled = false;
        }
    }
}
