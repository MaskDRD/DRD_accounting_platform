using accounting_platform.utl;
using System.Data;

namespace accounting_platform.repository
{
    class WorkerRepository
    {
        public DataTable selectWorker()
        {
            string sql = "call worker_get()";
            return ConnentMain.Instance.getDataTableSql(sql);
        }
    }
}
