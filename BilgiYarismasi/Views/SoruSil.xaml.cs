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

namespace BilgiYarismasi.Views
{
    /// <summary>
    /// Interaction logic for SoruSil.xaml
    /// </summary>
    public partial class SoruSil : Page
    {
        public SoruSil()
        {
            InitializeComponent();
        }

        private void Btn_Delete(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(txt_delete.Text);
            ViewModels.Database db = new ViewModels.Database();
            string command = "exec deleteQuestion @id = " + id;
            db.ConnectDb();
            db.SqlQuery(command);
            db.CloseDb();
        }

        private void Btn_ClearAll(object sender, RoutedEventArgs e)
        {
            ViewModels.Database db = new ViewModels.Database();
            string command = "truncate table Sorular";
            db.ConnectDb();
            db.SqlQuery(command);
            db.CloseDb();
        }
    }
}
