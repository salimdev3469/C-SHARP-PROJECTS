using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISA_PERMISSION_FORM_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.NameSurname = "John Smith";
            person1.IsAlive = false;

            Person person2 = new Person();
            person2.NameSurname = "Mehmet Yılmaz";
            person2.IsAlive = true;

            Person person3 = new Person();
            person3.NameSurname = "Salim Serhat Aka";
            person3.IsAlive = true;

            Person person4 = new Person()
            {
                NameSurname = "Helga Schloss",
                IsAlive = true
            };

            MessageBox.Show(person3.showUserName());
            MessageBox.Show(Person.Greetings());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurkishCitizen cit1 = new TurkishCitizen();
            cit1.BirthDate = Convert.ToDateTime("1990-05-06");
            MessageBox.Show(cit1.HaveVisa());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmericanCitizen usa1 = new AmericanCitizen();
            usa1.NameSurname = "Barack Obama";
            usa1.Language = "Engliswh";
            usa1.BirthDate = Convert.ToDateTime("1985-01-02");
            int date = DateTime.Today.Year;
            if (usa1.Language!="English")
            {
                MessageBox.Show("Your age is "+(date-usa1.BirthDate.Year)+" but your language is not english so you can not apply.");

            }
            else
            {
                MessageBox.Show("You can apply.");
            }
        }
    }
}
