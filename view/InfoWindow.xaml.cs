using accounting_platform.repository;
using System;
using System.Data;
using System.Windows;

namespace accounting_platform.view
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        private readonly StatusAttendanceRepository statusAttendanceRepository = new StatusAttendanceRepository();
        private readonly StatusWorkerRepository statusWorkerRepository = new StatusWorkerRepository();
 
        public DataTable statusWorkerTableData { get; set; }
        public DataTable statusAttendanceTableData { get; set; }
        public string title = "Таблица: Статусы сотрудников";
        public InfoWindow()
        {
            statusAttendanceTableData = statusAttendanceRepository.selectStatusAttendanceTable();
            statusWorkerTableData = statusWorkerRepository.selectStatusWorker();
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {  }
    }
}
