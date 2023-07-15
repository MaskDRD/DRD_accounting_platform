using accounting_platform.utl;
using System.Data;

namespace accounting_platform.repository
{
    class StatusWorkerRepository
    {
        public DataTable selectStatusWorker()
        {
            string sql = "SELECT * FROM status_worker";
            DataTable dataTable = ConnentMain.Instance.getDataTableSql(sql);
            dataTable.Columns[0].ColumnName = "id";
            dataTable.Columns[1].ColumnName = "Имя";
            dataTable.Columns[2].ColumnName = "Описание";
            return dataTable;
        }
    }
}
