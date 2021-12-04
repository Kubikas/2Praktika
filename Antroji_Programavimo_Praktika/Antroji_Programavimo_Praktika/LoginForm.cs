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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string Tekstas;

        private void button1_Click(object sender, EventArgs e)
        {

            MY_DB db = new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Adminas` WHERE `username`=@usn AND `password` = @pass", db.GetConnection);
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `Destytojas` WHERE `username`=@usn AND `password` = @pass", db.GetConnection);
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `Studentas` WHERE `username`=@usn AND `password` = @pass", db.GetConnection);
            
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textLoginUser.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textLoginPass.Text;

            command1.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textLoginUser.Text;
            command1.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textLoginPass.Text;

            command2.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textLoginUser.Text;
            command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textLoginPass.Text;

            adapter.SelectCommand = command;
            adapter1.SelectCommand = command1;
            adapter2.SelectCommand = command2;
            adapter.Fill(table);
            adapter1.Fill(table1);
            adapter2.Fill(table2);
            if (table.Rows.Count > 0)
            {
               // MessageBox.Show("Prisijungei kaip adminas");
                MainAdmino mainas = new MainAdmino();
                mainas.ShowDialog();
                this.Close();

            }
            if (table1.Rows.Count > 0)
            {
                //MessageBox.Show("Prisijungei kaip destytojas");

                Tekstas = textLoginUser.Text;
                //LoginForm form1 = new LoginForm();
               // form1.Show();
           
                
                MainDestytojo destmain = new MainDestytojo();
                destmain.ShowDialog();
                this.Close();
            }
            if (table2.Rows.Count > 0)
            {
                Tekstas = textLoginUser.Text;
                //MessageBox.Show("Prisijungei kaip Studentas");
                MainStudento stud = new MainStudento();
                stud.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Blogai ivestas vardas arba slaptazodis");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textLoginUser.Text = MainDestytojo.istatimas;
            textLoginUser.Text = PazimysForm.istatimas;
            textLoginUser.Text = PazimysUpdateForm.istatimas;
            textLoginUser.Text = MainStudento.istatimas;

        }
    }
}
