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

namespace WpfApplication2
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            Hide();
        }

        private void SMS_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("SMS ist sent.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bBackspace_Click(object sender, RoutedEventArgs e)
        {
            string newText = txt_SMS.Text;

            if (newText.Length > 0) newText = newText.Substring(0, newText.Length - 1);

            txt_SMS.Text = newText;
        }
    }
}
