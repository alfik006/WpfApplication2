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

namespace WpfApplication2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Window2 W2 = new Window2();
            W2.txtPhone_W2.Text = txtPhone.Text;
            W2.Show();
            Hide();
        }

        private void numbers_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            txtPhone.Text = txtPhone.Text + (string)button.Content;
        }

        private void SMS_Click(object sender, RoutedEventArgs e)
        {
            Window1 W1 = new Window1();
            W1.txtPhone_W1.Text = txtPhone.Text;
            W1.Show();
            Hide();

        }

       
        private void Call_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Call");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
