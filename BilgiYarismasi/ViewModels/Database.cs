using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace BilgiYarismasi.ViewModels
{
    class Database
    {
        private string db;
        private SqlConnection conn;
        private SqlCommand command;
        public SqlDataAdapter adapter;
        private SqlDataReader reader;
        private DataTable dt;

        public Database()
        {
            db = "Data Source = BURHACK; Initial Catalog = BilgiYarismasiDb; Integrated Security = True";
            conn = new SqlConnection(db);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dt = new DataTable();
        }
        public string Db
        {
            get { return db; }
            set { db = value; }
        }

        public DataTable Dt
        {
            get { return dt; }
        }
        public void ConnectDb()
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex) {
                MessageBox.Show("hata" + ex.Message, "Uyarı!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        public void CloseDb()
        {
            conn.Close();
        }

        public void SqlQuery(string comm)
        {
            command = new SqlCommand(comm, conn);
            reader = command.ExecuteReader();
            reader.Read();
            
        }

        public void SelectQuery(string comm)
        {
            adapter = new SqlDataAdapter(comm, conn);
            adapter.Fill(dt);
        }

    }
}
