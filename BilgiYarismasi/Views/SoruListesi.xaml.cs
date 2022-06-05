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
using System.Configuration;

namespace BilgiYarismasi.Views
{
    /// <summary>
    /// Interaction logic for SoruListesi.xaml
    /// </summary>
    public partial class SoruListesi : Page
    {
        public SoruListesi()
        {
            InitializeComponent();
        }

        private void liste_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModels.Database db = new ViewModels.Database();
            string command = "select * from sorular";
            db.ConnectDb();
            db.SelectQuery(command);
            dataGridview1.ItemsSource = db.Dt.DefaultView;
            db.CloseDb();
        }
        
    }
}
