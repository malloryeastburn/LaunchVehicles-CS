using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchVehicles
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        //Exit App
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLV1_MouseEnter(object sender, EventArgs e)
        {
            imgLV.Image = Bitmap.FromFile("C:\\Users\\mallo\\OneDrive\\Desktop\\100DaysofCode\\CS-Projects\\LaunchVehicles\\LaunchVehicles\\Resources\\Falcon_Heavy.jpg");
        }

        private void btnLV1_MouseLeave(object sender, EventArgs e)
        {
            imgLV.Image = null;
        }
    }
}
