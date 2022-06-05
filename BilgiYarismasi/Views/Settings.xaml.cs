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
using System.Data.SqlClient;
using System.Data;

namespace BilgiYarismasi.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Btn_Liste(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("Views/SoruListesi.xaml",
             UriKind.RelativeOrAbsolute));
            settings.Title = "Sorular";
        }

        private void Btn_Ekle(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("Views/SoruEkle.xaml",
             UriKind.RelativeOrAbsolute));
            settings.Title = "Soru Ekle";
        }

        private void Btn_Guncelle(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("Views/SoruGuncelle.xaml",
             UriKind.RelativeOrAbsolute));
            settings.Title = "Soru Güncelle";
        }

        private void Btn_Sil(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("Views/SoruSil.xaml",
             UriKind.RelativeOrAbsolute));
            settings.Title = "Soru Sil";
        }

        private void Btn_Rekorlar(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Navigate(new System.Uri("Views/Rekorlar.xaml",
             UriKind.RelativeOrAbsolute));
            settings.Title = "Rekorlar";
        }

    }
}
