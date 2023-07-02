using accounting_platform.repository;
using System.Data;
using System.Windows;

namespace accounting_platform.view
{
    /// <summary>
    /// Логика взаимодействия для WorkerWindow.xaml
    /// </summary>
    public partial class WorkerWindow : Window
    {
        private readonly WorkerRepository workerRepository = new WorkerRepository();
        private DataTable workerTableData = new DataTable();

        public WorkerWindow()
        {
            InitializeComponent();
            workerTableData = workerRepository.selectWorker();
            workerTable.ItemsSource = workerTableData.DefaultView;
        }
    }
}
