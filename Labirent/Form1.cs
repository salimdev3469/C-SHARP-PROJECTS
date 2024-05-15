using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Labirent
{
    public partial class Labirent : Form
    {
       
     
        public Labirent()
        {
            InitializeComponent();
            MoveUp();
           
        }

        private void FinishBar(object sender, EventArgs e)
        {
            MessageBox.Show("CONGRATS!");
            Close();
        }

        public void MoveUp()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            MoveUp();
         
        }
    }
}
