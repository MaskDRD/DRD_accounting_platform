using System;
using System.Configuration;
using System.Windows;

namespace accounting_platform.view
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
