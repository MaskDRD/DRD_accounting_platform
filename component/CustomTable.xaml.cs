using System;
using System.Collections.Generic;
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
        public static readonly DependencyProperty dataTablesProperty = DependencyProperty.Register("DataTables", typeof(DataTable), typeof(CustomTable));
 
        public string Title { get; set; }
 


        public CustomTable()
        {
            customTable.ItemsSource = DataTables.DefaultView;
            InitializeComponent();
        }

        public DataTable DataTables
        {
            get { return (DataTable)GetValue(dataTablesProperty); }
            set { SetValue(dataTablesProperty, value); }
        }
 
    }
}
