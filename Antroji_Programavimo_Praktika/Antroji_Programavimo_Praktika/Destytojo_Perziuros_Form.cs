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
    public partial class Destytojo_Perziuros_Form : Form
    {
        public Destytojo_Perziuros_Form()
        {
            InitializeComponent();
        }

        DESTYTOJAS dest = new DESTYTOJAS();

        private void Destytojo_Perziuros_Form_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT `id`, `username`, `password`, `vardas`, `pavarde`, `dalykas` FROM `destytojas`"));
        }


        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = dest.getDestytojas(command);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT `id`, `username`, `password`, `vardas`, `pavarde`, `dalykas` FROM `destytojas` WHERE CONCAT (`username`,`vardas`,`pavarde`,`dalykas`) LIKE'%" + textDestpaiesk.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(textDestpaiesk.Text);
                if(MessageBox.Show("Ar tikrai norite pasalinti destytoja ?", "Destytojo salinimas",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(dest.deleteDestytojas(id))
                    {
                        MessageBox.Show("Destytojas panaikintas");
                    }
                }
                else
                {
                    MessageBox.Show("nepavyko");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT `id`, `username`, `password`, `vardas`, `pavarde`, `dalykas` FROM `destytojas`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = dest.getDestytojas(command);
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
