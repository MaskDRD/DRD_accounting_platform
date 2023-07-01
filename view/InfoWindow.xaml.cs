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
        private DataTable statusAttendanceTableData = new DataTable();
        private DataTable statusWorkerTableData = new DataTable();
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            statusAttendanceTableData = statusAttendanceRepository.selectStatusAttendanceTable();
            statusAttendanceTable.ItemsSource = statusAttendanceTableData.DefaultView;

            statusWorkerTableData = statusWorkerRepository.selectStatusWorker();
            statusWorkerTable.ItemsSource = statusWorkerTableData.DefaultView;
        }
    }
}
