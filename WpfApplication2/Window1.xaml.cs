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
            if (30 - (250 - windowframe.Height) > 0) tmp.Height = 30 - ((250 - windowframe.Height) / 3);
            if (40 - (350 - windowframe.Width) > 0) tmp.Width = 40 - ((350 - windowframe.Width) / 3);
            if (100 - (250 - windowframe.Height) > 0) txt_SMS.Width = 100 - ((250 - windowframe.Width) / 3);
            if (250 - (350 - windowframe.Height) > 0) txt_SMS.Width = 250 - ((350 - windowframe.Width) / 3);

            //Set dynamic fontsize
            if (tmp.Width > tmp.Height) tmp.FontSize = 17 * tmp.Height / 70;
            else tmp.FontSize = 17 * tmp.Width / 30;

            //Set dynamic position on grid
            Thickness margin = txtPhone_W1.Margin;

            //Head
            margin.Top = 10;
            margin.Left = 20 + label1.Width + 20;
            txtPhone_W1.Margin = margin;

            //SMS Window
            margin.Left = 20;
            margin.Top = 10 + tmp.Height + 10;
            txt_SMS.Margin = margin;

            //Key row
            margin.Left = 20;
            margin.Top = 3*10 + txt_SMS.Height + tmp.Height;
            bBackspace.Margin = margin;

            margin.Left = 2*20 + tmp.Width;
            bSMS.Margin = margin;

            margin.Left = 3*20 + 2*tmp.Width; ;
            bCancel.Margin = margin;

        }

    }
}
