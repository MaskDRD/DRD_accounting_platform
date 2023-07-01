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
            return ConnentMain.Instance.getDataTableSql(sql);
        }
    }
}
