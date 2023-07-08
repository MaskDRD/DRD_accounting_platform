using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace accounting_platform.utl
{
    sealed class ConnentMain: Singleton<ConnentMain>
    {
        private MySqlConnection connection;

        public ConnentMain()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        public DataTable getDataTableSql(string sql) {
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
