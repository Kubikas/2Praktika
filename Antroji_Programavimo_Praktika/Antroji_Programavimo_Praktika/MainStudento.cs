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
    public partial class MainStudento : Form
    {
        public static string istatimas;

        public MainStudento()
        {
            InitializeComponent();
        } 

        STUDENT student = new STUDENT();
        DESTYTOJAS destytojas = new DESTYTOJAS();
        GRADE grades = new GRADE();
        private void MainStudento_Load(object sender, EventArgs e)
        {

            // fillGrid1(new MySqlCommand("SELECT `dalykas` FROM `destytojas`"));
            fillGrid(new MySqlCommand("SELECT `pazimys`, `dalykas` FROM `grades`")); 
            textBoxPazimys55.Text = LoginForm.Tekstas;

            string query = "SELECT DISTINCT `pazimys`, `dalykas` FROM `grades` WHERE CONCAT (`username`) LIKE'%" + textBoxPazimys55.Text + "%'";
            MySqlCommand command = new MySqlCommand(query);
            fillGrid(command);
        }
       
        public void fillGrid(MySqlCommand command)
        {
            dataGridViewPazimys.ReadOnly = true;
            dataGridViewPazimys.RowTemplate.Height = 40;
            //dataGridViewPazimys.Width = 200;
            dataGridViewPazimys.DataSource = grades.getDestytojas(command);

        }
    }
}
