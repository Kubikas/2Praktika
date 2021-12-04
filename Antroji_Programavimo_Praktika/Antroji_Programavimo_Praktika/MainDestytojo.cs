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
    public partial class MainDestytojo : Form
    {
        public static string istatimas;
        public MainDestytojo()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        DESTYTOJAS destytojas = new DESTYTOJAS();
        GRADE grades = new GRADE();

        private void MainDestytojo_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT `id`, `vardas`, `pavarde`, `grupe`, `pazimys`, `username` FROM `studentas`"));
            fillGrid1(new MySqlCommand("SELECT DISTINCT `pazimys`, `pavarde`, `vardas`, `grupe`, `username` FROM `grades`"));
            textBoxdestytojupaste.Text = LoginForm.Tekstas;

            string query = "SELECT DISTINCT `pazimys`, `pavarde`, `vardas`, `grupe`, `username` FROM `grades` WHERE CONCAT (`dalykas`) LIKE'%" + textBoxdestytojupaste.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid1(command);

        }
        //pazimys
        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = student.getStudents(command); 

        }
        public void fillGrid1(MySqlCommand command)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.DataSource = grades.getDestytojas(command);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT `id`, `vardas`, `pavarde`, `grupe`, `pazimys` FROM `studentas` WHERE CONCAT (`grupe`) LIKE'%" + textBoxGrupesPaieska.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PazimysForm forma = new PazimysForm();
            forma.textBoxIDa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            forma.textBoxPazVardas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            forma.textBoxPazPavarde.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            forma.textBoxPazGrupe.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            forma.textBoxPazimys.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            forma.textBoxStudentoUsername.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            forma.Show();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)        {  }




        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT `pazimys`, `pavarde`, `vardas`, `grupe`, `username` FROM `grades` WHERE CONCAT (`dalykas`) LIKE'%" + textBoxdestytojupaste.Text + "%'");
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.DataSource = grades.getDestytojas(command);
            dataGridView2.AllowUserToAddRows = false;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dataGridView2_DoubleClick_1(object sender, EventArgs e)
        {
            PazimysUpdateForm forma2 = new PazimysUpdateForm();
            // forma.textBoxIDa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            forma2.textBoxPazVardasUPD.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            forma2.textBoxPazPavardeUPD.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            forma2.textBoxPazGrupeUPD.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            forma2.textBoxPazimysUPD.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            forma2.textBoxUpdateStudentas.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

            forma2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /*
private void button3_Click(object sender, EventArgs e)
{
  textBoxdestytojupaste.Text = LoginForm.Tekstas;
}
*/
    }
}
