using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Antroji_Programavimo_Praktika
{
    public partial class Grupiu_Sarasas : Form
    {
        public Grupiu_Sarasas()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void Grupiu_Sarasas_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT DISTINCT `grupe` FROM `studentas`"));


        }
        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
               
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT * FROM `grupe` WHERE CONCAT (`grupespav`) LIKE'%" + textBoxGrupesS.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();


            string pav = GrupSal.Text;

            if (MessageBox.Show("Ar tikrai norite pasalinti grupe ?", "Grupes salinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                student.deleteStudentGrupe(pav);
            }
            else
            {
                MessageBox.Show("nepavyko");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("SELECT DISTINCT `grupe` FROM `studentas`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
