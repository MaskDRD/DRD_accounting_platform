using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace accounting_platform.component
{
    /// <summary>
    /// Логика взаимодействия для CustomTable.xaml
    /// </summary>
    public partial class CustomTable : UserControl
    {
        public readonly DependencyProperty dataTablesProperty;
        public string Title { get; set; }
        

        public CustomTable()
        {
            this.DataContext = this;
            this.dataTablesProperty = DependencyProperty.Register("dataTables", typeof(DataTable), typeof(CustomTable));
            InitializeComponent();
            Console.WriteLine(dataTables);
        }

        public DataTable dataTables
        {
            get { return (DataTable)GetValue(dataTablesProperty); }
            set { SetValue(dataTablesProperty, value); }
        }
    }
}
