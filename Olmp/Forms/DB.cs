using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
using OpenXmlPowerTools;

namespace Olmp.Forms
{
    class DB
    {
        public string connectionString = "Host=localhost;Username=postgres;Password=' ';Database=DB";
        public void SigUp(string email, string password)
        {
                NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
                npgSqlConnection.Open();
                NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO users(email, password) VALUES ('{email}', '{password}')", npgSqlConnection);
                npgSqlCommand.ExecuteNonQuery();
                npgSqlConnection.Close();
            



        }

        public void CheckEmail(string email, out bool checkEmail) {
            checkEmail = false;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT email FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (!npgSqlDataReader.HasRows)
                checkEmail = true;
            npgSqlConnection.Close();

        }


        public void SignIn(string email, out string password, out bool pr)
        {
            password = "";
            pr = true;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT password FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    password = dbDataRecord["password"].ToString();
            if (!npgSqlDataReader.HasRows)
                pr = false;
            npgSqlConnection.Close();
        }


        public void amountApp(string email, out int amount)
        {
            amount = 0;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT nameApp FROM app WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    amount++;
            npgSqlConnection.Close();
        }

        public void addApp(string name, string ucode, string email)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO app(email, name, ucode, date, view, edit) VALUES ('{email}', '{name}', '{ucode}', '{DateTime.Now:g}', '0', '0')", npgSqlConnection);
            npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
        }

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public void appList(string email, DataGridView gridListApp)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            //NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT 'Уникальный код' = SUBSTRING(app.ucode,1,50), 'Название' =SUBSTRING(app.name,1,50), 'Дата добавления' = SUBSTRING(app.date,1,50) FROM app WHERE email = '{email}';", npgSqlConnection);
            string com = $"SELECT 'Уникальный код' = SUBSTRING(app.ucode,1,50), 'Название' =SUBSTRING(app.name,1,50), 'Дата добавления' = SUBSTRING(app.date,1,50) FROM app WHERE email = '{email}'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(com, connectionString);
            //NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            gridListApp.DataSource = dt;                   
            npgSqlConnection.Close();

        }
        public void CheckUCode(string ucode, out bool check)
        {
            check = false;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT ucode FROM app Where ucode = {ucode}", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                check = true;
            npgSqlConnection.Close();
        }

        public void statsApp (string email, Chart chrt)
        {
            int view = 0, edit = 0;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT view, edit FROM app Where email = {email}", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                {
                    view = int.Parse(dbDataRecord["view"].ToString());
                    edit = int.Parse(dbDataRecord["edit"].ToString());
                }
            chrt.Series[0].Points.AddXY(view);
            chrt.Series[1].Points.AddXY(edit);


        }
    }
}
