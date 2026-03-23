using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NASACLI;

namespace NasaWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnAllData_Click(object sender, RoutedEventArgs e) {
            Program.Beolvas();
            dtgDatas.ItemsSource = Program.kuldetesek;
        }

        private void dtgDatas_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            lblTitle.Content = (dtgDatas.SelectedItem as Kuldetes).Nev;
            progressBar.Value = (dtgDatas.SelectedItem as Kuldetes).HasznosTeher;
        }
    }
}