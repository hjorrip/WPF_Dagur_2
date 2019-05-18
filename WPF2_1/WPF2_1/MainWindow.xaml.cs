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

namespace WPF2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string place = cbPlaces.Text;

            ListBoxItem lbi = new ListBoxItem();
            lbi.Content = place;
            lbPlaces.Items.Add(lbi);

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            lbPlaces.Items.Remove(lbPlaces.SelectedItem);
        }
    }
}
