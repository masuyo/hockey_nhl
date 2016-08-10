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

namespace hockey_nhl
{
    /// <summary>
    /// Interaction logic for NHLRoster.xaml
    /// </summary>
    public partial class NHLRoster : Window
    {
        public NHLRoster()
        {
            InitializeComponent();

            StatusBox.ItemsSource = Enum.GetValues(typeof(StatusOptions));
            PositionBox.ItemsSource = Enum.GetValues(typeof(PositionOptions));
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: elmentse a változásokat/hozzáadást

            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
