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
using System.Data.SqlClient;
using System.Data;

namespace BilgiYarismasi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Question q = new Question();
            //q.Secenek.SetValue("dasjkasf", 2);
            //MessageBox.Show(q.Secenek.GetValue(2).ToString());
        }

        private void Btn_Start(object sender, RoutedEventArgs e)
        {
            Views.Start st = new Views.Start();
            st.Show();
        }

        private void Btn_Stg(object sender, RoutedEventArgs e)
        {
            Views.Settings stg = new Views.Settings();
            stg.Show();

        }

        private void Btn_Exit(object sender, RoutedEventArgs e)
        {
            Views.Exit ext = new Views.Exit();
            ext.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Views.Exit ext = new Views.Exit();
            ext.Show();
        }

    }
}
