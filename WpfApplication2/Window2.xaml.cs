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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            Hide();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Contact_sound.Play();
        }

        private void windowframe_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Set dynamic object size
            if (40 - (420 - windowframe.Height) > 0) tmp.Height = 40 - ((420 - windowframe.Height) / 6);
            if (40 - (210 - windowframe.Width) > 0) tmp.Width = 40 - ((210 - windowframe.Width) / 3);

            //Set dynamic fontsize
            if (tmp.Width > tmp.Height) tmp.FontSize = 17 * tmp.Height / 40;
            else tmp.FontSize = 17 * tmp.Width / 40;


        }
    }
}
