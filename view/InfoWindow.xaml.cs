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
        private DataTable statusAttendanceTableData = new DataTable();
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            statusAttendanceTableData = statusAttendanceRepository.selectStatusAttendance();
            statusAttendanceTable.ItemsSource = statusAttendanceTableData.DefaultView;
        }
    }
}
