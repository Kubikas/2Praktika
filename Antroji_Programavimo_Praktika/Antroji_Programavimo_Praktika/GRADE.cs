using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Antroji_Programavimo_Praktika
{
    class GRADE
    {
        MY_DB db = new MY_DB();

        public bool insertGrade(string pazimys, string vardas, string pavarde, string dalykas, string grupe, string username)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `grades`(`pazimys`, `vardas`, `pavarde`, `dalykas`, `grupe`, `username`) VALUES (@paz,@var,@pav,@daly,@gr,@usr)", db.GetConnection);


            command.Parameters.Add("@paz", MySqlDbType.VarChar).Value = pazimys;
            command.Parameters.Add("@var", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pavarde;
            command.Parameters.Add("@daly", MySqlDbType.VarChar).Value = dalykas;
            command.Parameters.Add("@gr", MySqlDbType.VarChar).Value = grupe;
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;




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

        public bool updateGrade(string pazimys, string vardas, string pavarde, string dalykas, string grupe, string username)
        {
            //`vardas`, `pavarde`, `dalykas`, `grupe`) VALUES (@paz,@var,@pav,@daly,@gr)
            MySqlCommand command = new MySqlCommand("UPDATE `grades` SET `pazimys`=@paz, `vardas`=@var, `grupe`=@gr, `username`=@usr WHERE `pavarde`=@ID AND `dalykas`=@dal", db.GetConnection);


            command.Parameters.Add("@paz", MySqlDbType.VarChar).Value = pazimys;
            command.Parameters.Add("@var", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@dal", MySqlDbType.VarChar).Value = dalykas;
            command.Parameters.Add("@gr", MySqlDbType.VarChar).Value = grupe;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = pavarde;
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;



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





        /*
        public bool insertDest(string dalykas)
        {

            MySqlCommand command = new MySqlCommand("SELECT `dalykas` FROM `destytojas` WHERE dalykas1=@dal", db.GetConnection);

            command.Parameters.Add("@paz", MySqlDbType.VarChar).Value = dalykas;
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
        */








        public DataTable getDestytojas(MySqlCommand command)
        {
            command.Connection = db.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool updatePazimys(string pazimys, string pavarde)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `grades` SET `pazimys`=@paz WHERE `pavarde`=@ID", db.GetConnection);

            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = pavarde;
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





    }
}
