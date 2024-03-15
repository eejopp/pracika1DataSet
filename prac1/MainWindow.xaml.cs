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
using prac1.BeautySalDataSetTableAdapters;

namespace prac1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsTableAdapter clients = new ClientsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            grid_salon.ItemsSource = clients.GetData();
        }
    }
}
