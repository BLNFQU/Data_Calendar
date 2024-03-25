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

namespace WpfApplication7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bSend.IsEnabled = false;
        }

        private void dpBirghtday_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(tbAge.Text != "" & tbName.Text != "" & tbNumber.Text != "" & tbSubName.Text != "")
            {
                bSend.IsEnabled = true;
            }
            else
            {
                bSend.IsEnabled = false;
            }
        }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {
            User usr = new User(tbName.Text,tbSubName.Text,int.Parse(tbAge.Text),int.Parse(tbNumber.Text),dpBirghtday.Text);
            MessageBox.Show(usr.Show());
        }
    }
}
