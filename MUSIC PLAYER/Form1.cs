//Developed by Salim Serhat AKA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_PLAYER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] paths, files;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=paths[listBox1.SelectedIndex];//Code that sends the path of the selected music inside the listbox to the media player.
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();//this whole event is a common pattern to select or place a file or doc (ezberlenecek bir bilgi degil dosya seçim islemlerinde kullanilan kaliplasmis bir patern)
            ofd.Multiselect = true;//Code that make it able to select multiple songs
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if(ofd.ShowDialog() == DialogResult.OK) it is same if we write it this way
            {
                files= ofd.SafeFileNames;//Save the names of the tracks into files array
                paths=ofd.FileNames;//Save the path of the tracks into path array
                //Displaying the names of tracks in listBox
                for(int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }
        }

       
    }
}
