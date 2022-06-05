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
    /// Interaction logic for SoruEkle.xaml
    /// </summary>
    public partial class SoruEkle : Page
    {
        public SoruEkle()
        {
            InitializeComponent();
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Soru Ekle";
            txt2.Text = "A Şıkkı";
            txt3.Text = "B Şıkkı";
            txt4.Text = "C Şıkkı";
            txt5.Text = "D Şıkkı";
            txt1.FontSize = 25;
            txt2.FontSize = 15;
            txt3.FontSize = 15;
            txt4.FontSize = 15;
            txt5.FontSize = 15;
        }
        bool[] durum = { true, true, true, true, true };

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txtislem = sender as TextBox;
            
            if (txtislem != null)
            {
                decimal deger = Convert.ToDecimal(txtislem.Tag);
                if (deger == 0)
                {
                    if (durum[0])
                    {
                        txt1.Clear();
                        durum[0] = false;
                    }
                }
                else if (deger == 1)
                {
                    if (durum[1])
                    {
                        txt2.Clear();
                        durum[1] = false;
                    }
                }
                else if (deger == 2)
                {
                    if (durum[2])
                    {
                        txt3.Clear();
                        durum[2] = false;
                    }
                }
                else if (deger == 3)
                {
                    if (durum[3])
                    {
                        txt4.Clear();
                        durum[3] = false;
                    }
                }
                else if (deger == 4)
                {
                    if (durum[4])
                    {
                        txt5.Clear();
                        durum[4] = false;
                    }
                }
            }
            
        }

        private void Btn_Kaydet(object sender, RoutedEventArgs e)
        {
            Question q = new Question();
            q.Soru = txt1.Text;
            q.secenekA = txt2.Text;
            q.secenekB = txt3.Text;
            q.secenekC = txt4.Text;
            q.secenekD = txt5.Text;

            ViewModels.Database db = new ViewModels.Database();
            string command = "exec addQuestion @soru='" + q.Soru + "', @a='" + q.secenekA + "', @b='" + q.secenekB + "',@c='" + q.secenekC + "', @d='" + q.secenekD + "'";
            db.ConnectDb();
            db.SqlQuery(command);
            db.CloseDb();
        }

        private void Btn_Temizle(object sender, RoutedEventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
        }

       
    }
}
