using accounting_platform.utl;
using System.Data;

namespace accounting_platform.repository
{
    class StatusWorkerRepository
    {
        public DataTable selectStatusWorker()
        {
            string sql = "SELECT * FROM status_worker";
            return ConnentMain.Instance.getDataTableSql(sql);
        }
    }
}
