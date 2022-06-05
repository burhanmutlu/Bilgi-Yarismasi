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
using System.Windows.Shapes;

namespace BilgiYarismasi.Views
{
    /// <summary>
    /// Interaction logic for Exit.xaml
    /// </summary>
    public partial class Exit : Window
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void Btn_Geri(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Cik(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1); 
        }
    }
}
