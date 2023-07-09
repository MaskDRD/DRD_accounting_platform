using accounting_platform.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace accounting_platform
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkerWindow workerWindow = new WorkerWindow();
            workerWindow.Show();
        }

        private void ButtonPosition_Click(object sender, RoutedEventArgs e)
        {
            PositionWindow positionWindow = new PositionWindow();
            positionWindow.Show();
        }

        private void ButtonAttendance_Click(object sender, RoutedEventArgs e)
        {
            AttendanceWindow attendanceWindow = new AttendanceWindow();
            attendanceWindow.Show();
        }

        private void ButtonSalary_Click(object sender, RoutedEventArgs e)
        {
            SalaryWindow salaryWindow = new SalaryWindow();
            salaryWindow.Show();
        }

        private void ButtonDr_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            Test testWindow = new Test();
            testWindow.Show();
        }
    }
}
