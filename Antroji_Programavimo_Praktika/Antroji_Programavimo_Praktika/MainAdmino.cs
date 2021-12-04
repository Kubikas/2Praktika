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
    public partial class MainAdmino : Form
    {
        public MainAdmino()
        {
            InitializeComponent();
        }

        private void pridetiNaujaStudentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studento_Pridejimo_Form stu = new Studento_Pridejimo_Form();
            stu.ShowDialog();
        }

        private void pridetiDestytojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destytojo_Pridejimo_Form des = new Destytojo_Pridejimo_Form();
            des.ShowDialog();
        }

        private void studentuGrupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupiu_Sarasas grup = new Grupiu_Sarasas();
            grup.ShowDialog();
        }

        private void studentuSarasasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentu_Sarasas_Form st = new Studentu_Sarasas_Form();
            st.ShowDialog();
        }

        private void destytojuSarasasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destytojo_Perziuros_Form dst = new Destytojo_Perziuros_Form();
            dst.ShowDialog();
        }

        private void MainAdmino_Load(object sender, EventArgs e)
        {

        }
    }
}
