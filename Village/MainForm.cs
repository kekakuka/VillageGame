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
   
    public partial class MainForm : Form
    {
        private BuildingsController theController;
        private ViewForm1 myViewForm1;
        private ViewForm2 myViewForm2;
        private ViewForm3 myViewForm3;
        private BuildingsModel theModel;
        public MainForm()
        {
            InitializeComponent();
        }

        public static void OtherForms()
        {

          
           

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            //make controller
            theController = new BuildingsController();
            //make model
            theModel = new BuildingsModel(theController);
            //make views
           
                myViewForm1 = new ViewForm1();
           
                                
          
               
            
                myViewForm2 = new ViewForm2();
            
                myViewForm3 = new ViewForm3();
           
              
            myViewForm1.MyModel = theModel;
            myViewForm2.MyModel = theModel;
            myViewForm3.MyModel = theModel;
            //add views to controller
    
            theController.AddView(myViewForm1);
            theController.AddView(myViewForm2);
            theController.AddView(myViewForm3);

            //show views       

            myViewForm1.Show();
            myViewForm3.Show();

            myViewForm2.Show();

        }
    }
}
