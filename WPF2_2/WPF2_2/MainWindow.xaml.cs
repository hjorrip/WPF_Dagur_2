using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF2_2
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
            ListBoxItem lbi = new ListBoxItem()
            {
                Content = txtInput.Text
            };

            if (!txtInput.Text.Equals(""))
            {
                lbProducts.Items.Add(lbi);
                txtInput.Text = "";

            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            lbProducts.Items.Remove(lbProducts.SelectedItem);
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "*.txt";
            dlg.Filter = "Shopping list|*.txt";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string[] products =  File.ReadAllLines(dlg.FileName);
                foreach (string s in products)
                {
                    ListBoxItem lbi = new ListBoxItem()
                    {
                        Content = s
                    };

                    lbProducts.Items.Add(lbi);
                }

            }


        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "*.txt";
            dlg.Filter = "Shopping list|*.txt";
            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                List<string> products = new List<string>();
                foreach (ListBoxItem lbi in lbProducts.Items)
                {
                    products.Add(lbi.Content.ToString());
                }
                try
                {
                    File.WriteAllLines(dlg.FileName, products);
                    MessageBox.Show("Innkaupalisti vistaður!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Villa 56B - Hafðu samband við kerfisstjóra");
                }
            }


        }
    }
}
