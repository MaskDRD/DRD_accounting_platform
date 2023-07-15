
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
        public static readonly DependencyProperty DataTableProperty = DependencyProperty.Register(
                "DataTable",
                typeof(DataTable),
                typeof(CustomTable)
        );

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
                "Title",
                typeof(string),
                typeof(CustomTable)
        );

        public DataTable DataTable
        {
            get { return (DataTable)GetValue(DataTableProperty); }
            set { SetValue(DataTableProperty, value); }
        }

        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }



        public CustomTable()
        {  
            InitializeComponent();
        } 
    }
}
