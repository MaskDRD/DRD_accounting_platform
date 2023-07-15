using accounting_platform.utl;
using System.Data;

namespace accounting_platform.repository
{
    class StatusAttendanceRepository
    {        
        public StatusAttendanceRepository(){}

        public DataTable selectStatusAttendanceTable()
        {
            string sql = "SELECT * FROM status_attendance";
            DataTable dataTable = ConnentMain.Instance.getDataTableSql(sql);
            dataTable.Columns[0].ColumnName = "id";
            dataTable.Columns[1].ColumnName = "Имя";
            dataTable.Columns[2].ColumnName = "Описание";
            return dataTable;
        }
    }
}
