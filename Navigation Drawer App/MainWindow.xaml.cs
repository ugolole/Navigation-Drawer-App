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

namespace Navigation_Drawer_App
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

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set the tooltip visibility
            if(Tg_button.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_address.Visibility = Visibility.Collapsed;
                tt_contacts.Visibility = Visibility.Collapsed;
                tt_mail.Visibility = Visibility.Collapsed;
                tt_whatsapp.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_address.Visibility = Visibility.Visible;
                tt_contacts.Visibility = Visibility.Visible;
                tt_mail.Visibility = Visibility.Visible;
                tt_whatsapp.Visibility = Visibility.Visible;
            }
        }

        private void Tg_button_Unchecked(object sender, RoutedEventArgs e)
        {
            imag_bg.Opacity = 1;
        }

        private void Tg_button_Checked(object sender, RoutedEventArgs e)
        {
            imag_bg.Opacity = 0.3;
        }
    }
}
