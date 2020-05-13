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

namespace DomasRuginisS00188837
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Phone selectedPhone;

        List<Phone> Phones = new List<Phone>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LbxPhones_Loaded(object sender, RoutedEventArgs e)
        {
            Phones.Add(new Phone("Samsung S20", 500, "Android", "/Images/android.png", "/Images/s20.jpg"));
            Phones.Add(new Phone("iPhone11", 600, "IOS", "/Images/apple.png", "/Images/iphone11.png"));

            lbxPhones.ItemsSource = null;
            lbxPhones.ItemsSource = Phones;
        }

        private void ListBoxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPhone = lbxPhones.SelectedItem as Phone;

            if (lbxPhones.SelectedItem != null)
            {
                string phonePrice = $"Cost -> {selectedPhone.Price:C}";
                textBoxPrice.Text = null;
                textBoxPrice.Text = phonePrice;

                listBoxImage.ItemsSource = null;
                listBoxImage.ItemsSource = selectedPhone.Og_Image;
            }
        }

        
    }
}
