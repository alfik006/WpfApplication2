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

        private void windowframe_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Set dynamic object size
            if (40 - (250 - windowframe.Height) > 0) tmp.Height = 30 - ((250 - windowframe.Height));
            if (40 - (310 - windowframe.Width) > 0) tmp.Width = 60 - ((310 - windowframe.Width));
            if (100 - (250 - windowframe.Height) > 0) txt_SMS.Width = 220 - ((310 - windowframe.Width));
            if (100 - (250 - windowframe.Height) > 0) label1.Width = 220 - ((310 - windowframe.Width));

            //Set dynamic fontsize
            if (tmp.Width > tmp.Height) tmp.FontSize = 17 * tmp.Height / 60;
            else tmp.FontSize = 17 * tmp.Width / 60;

           //Set dynamic position on grid
            Thickness margin = bBackspace.Margin;
            Thickness margin2 = bBackspace.Margin;
            Thickness margin3 = bBackspace.Margin;

            //Head
            margin.Top = 170;
            margin.Left = 15;
            bBackspace.Margin = margin;

            margin.Top = 170;
            margin.Left = 110;
            bSMS.Margin = margin;

            margin.Top = 170;
            margin.Left = 180;
            bCancel.Margin = margin;

            margin.Top = 6;
            margin.Left = 50;
            txtPhone_W1.Margin = margin;

        }

    }
}
