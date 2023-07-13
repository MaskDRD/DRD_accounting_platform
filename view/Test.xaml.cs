using System.Windows;

namespace accounting_platform.view
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public string title { get; set; }

        public Test()
        {
            title = "2";
            InitializeComponent();
        }

        private void buttonNewTitle_Click(object sender, RoutedEventArgs e)
        {
            title = "5";
        }
    }
}
