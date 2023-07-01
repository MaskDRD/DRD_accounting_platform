using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace accounting_platform.repository
{
    class StatusAttendanceRepository
    {
        private MySqlConnection connection;
        public StatusAttendanceRepository(){

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }
        public DataTable selectStatusAttendance()
        {
            string sql = "SELECT * FROM status_attendance";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
