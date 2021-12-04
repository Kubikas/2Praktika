using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Antroji_Programavimo_Praktika
{
    class DESTYTOJAS
    {
        MY_DB db = new MY_DB();

        public bool insertdestytojas(string fname1, string lname1, string user1, string pass1, string dalyk, string pazimys)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `destytojas`(`username`, `password`, `vardas`, `pavarde`, `dalykas`, `pazimys`) VALUES (@name,@pas,@fn,@ln,@dl,@paz)", db.GetConnection);
            //  @fn,@ln,@name,@pas

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = user1;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = pass1;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname1;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname1;
            command.Parameters.Add("@dl", MySqlDbType.VarChar).Value = dalyk;
            command.Parameters.Add("@paz", MySqlDbType.VarChar).Value = pazimys;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool updatePazimysdest(int id, string pazimys1)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `destytojas` SET `pazimys`=@paz WHERE `id`=@ID", db.GetConnection);

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@paz", MySqlDbType.VarChar).Value = pazimys1;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }


        public DataTable getDestytojas(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        public bool deleteDestytojas(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `destytojas` WHERE `id`=@studentID", db.GetConnection);

            //  @ID

            command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
