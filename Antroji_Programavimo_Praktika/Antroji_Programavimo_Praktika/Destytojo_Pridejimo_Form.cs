using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika
{
    public partial class Destytojo_Pridejimo_Form : Form
    {
        public Destytojo_Pridejimo_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DESTYTOJAS dest = new DESTYTOJAS();
            string fname1 = TdestVardas.Text;
            string lname1 = TdestPavarde.Text;
            string user1 = TdestUsern.Text;
            string pass1 = TdestSlaptazod.Text;
            string dalyk = TdestDalykas.Text;
            string pazimys = pamirst.Text;

            if (verif())
            {
                if (dest.insertdestytojas(fname1, lname1, user1, pass1, dalyk, pazimys))
                {
                    MessageBox.Show("Naujas destytojas pridetas sekmingai!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Netinkamai ivesti duomenys");
                }
            }
            else
            {
                MessageBox.Show("Tusti laukai");
            }
        }
        bool verif()
        {
            if ((TdestVardas.Text.Trim() == "") ||
              (TdestPavarde.Text.Trim() == "") ||
              (TdestUsern.Text.Trim() == "") ||
              (TdestSlaptazod.Text.Trim() == "") ||
              (TdestDalykas.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Destytojo_Pridejimo_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
