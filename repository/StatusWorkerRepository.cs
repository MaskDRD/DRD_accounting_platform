﻿
using accounting_platform.utl;
using MySql.Data.MySqlClient;
using System.Data;

namespace accounting_platform.repository
{
    class StatusWorkerRepository
    {
        private DataTable selectStatusWorker()
        {
            string sql = "SELECT * FROM status_worker";
            return ConnentMain.Instance.getDataTableSql(sql);
        }
    }
}