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
            Numbers_sound.Play();
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
            Call_sound.Play();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bBackspace_Click(object sender, RoutedEventArgs e)
        {

            string newText = txtPhone.Text;

            if (newText.Length>0) newText = newText.Substring(0, newText.Length -1);

            txtPhone.Text = newText;

        }

        private void windowframe_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Set dynamic object size
            if (40 - (420 - windowframe.Height) > 0) tmp.Height = 40 - ((420 - windowframe.Height) / 6);
            if (40 - (210 - windowframe.Width) > 0) tmp.Width = 40 - ((210 - windowframe.Width) / 3);
            if (100 - (420 - windowframe.Height) > 0) txtPhone.Width = 100 - ((210 - windowframe.Width) / 3);

            //Set dynamic fontsize
            if (tmp.Width > tmp.Height) tmp.FontSize = 17 * tmp.Height / 40;
            else tmp.FontSize = 17 * tmp.Width / 40;

            //Set dynamic position on grid
            Thickness margin = button1.Margin;

            //Head
            margin.Top = 40;
            margin.Left = 20 + txtPhone.Width + 20;
            bBackspace.Margin = margin;

            //First row
            margin.Left = 20;
            margin.Top = 40 + tmp.Height + 20;
            button1.Margin = margin;

            margin.Left = 20 + tmp.Width + 20;
            margin.Top = 40 + tmp.Height + 20;
            button2.Margin = margin;

            margin.Left = 3 * 20 + 2 * tmp.Width;
            margin.Top = 40 + tmp.Height + 20;
            button3.Margin = margin;

            //Second row
            margin.Left = 20;
            margin.Top = 40 + 2 * tmp.Height + 2 * 20;
            button4.Margin = margin;

            margin.Left = 20 + tmp.Width + 20;
            margin.Top = 40 + 2 * tmp.Height + 2 * 20;
            button5.Margin = margin;

            margin.Left = 3 * 20 + 2 * tmp.Width;
            margin.Top = 40 + 2 * tmp.Height + 2 * 20;
            button6.Margin = margin;

            //Third row
            margin.Left = 20;
            margin.Top = 40 + 3 * tmp.Height + 3 * 20;
            button7.Margin = margin;

            margin.Left = 20 + tmp.Width + 20;
            margin.Top = 40 + 3 * tmp.Height + 3 * 20;
            button8.Margin = margin;

            margin.Left = 3 * 20 + 2 * tmp.Width;
            margin.Top = 40 + 3 * tmp.Height + 3 * 20;
            button9.Margin = margin;

            //Fourth row
            margin.Left = 20;
            margin.Top = 40 + 4 * tmp.Height + 4 * 20;
            bStern.Margin = margin;

            margin.Left = 20 + tmp.Width + 20;
            margin.Top = 40 + 4 * tmp.Height + 4 * 20;
            button0.Margin = margin;

            margin.Left = 3 * 20 + 2 * tmp.Width;
            margin.Top = 40 + 4 * tmp.Height + 4 * 20;
            bHashtag1.Margin = margin;

            //Fifth row
            margin.Left = 20;
            margin.Top = 40 + 5 * tmp.Height + 5 * 20;
            bSave.Margin = margin;

            margin.Left = 20 + tmp.Width + 20;
            margin.Top = 40 + 5 * tmp.Height + 5 * 20;
            bCall.Margin = margin;

            margin.Left = 3 * 20 + 2 * tmp.Width;
            margin.Top = 40 + 5 * tmp.Height + 5 * 20;
            bSMS.Margin = margin;

        }

    }
}