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
  
        public string Title { get; set; }
 


        public CustomTable()
        {
            this.DataContext = this;
            //customTable.ItemsSource = DataTables.DefaultView;
            InitializeComponent();
        } 
    }
}
