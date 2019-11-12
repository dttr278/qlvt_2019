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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainContentWindow.xaml
    /// </summary>
    public partial class MainContentWindow : Window
    {
        static private MainContentWindow signleton;
        static public MainContentWindow Signleton => signleton;
        static MainContentWindow()
        {
            if (signleton == null)
            {
                signleton = new MainContentWindow();
            }
        }
        private MainContentWindow()
        {
            InitializeComponent();
        }

        private void btnDSNhanVien_Click(object sender, RoutedEventArgs e)
        {
            pnContent.Children.Clear();
            pnContent.Children.Add(DSNhanVienControl.Singleton);
        }

        private void btnDSKho_Click(object sender, RoutedEventArgs e)
        {
            pnContent.Children.Clear();
            pnContent.Children.Add(KhoControl.Singleton);
        }
    }
}
