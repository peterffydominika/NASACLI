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

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            lblTitle.Content = "Statisztika";
            progressBar.Value = 0;
            List<Statisztika> statisztika = new List<Statisztika>();
            List<Kuldetes> Emberes = Program.kuldetesek.Where(x => x.Legenyseg > 0).ToList();
            List<Kuldetes> NemEmberes = Program.kuldetesek.Where(x => x.Legenyseg == 0).ToList();
            statisztika.Add(new Statisztika("Emberes küldetések", Emberes.Count, $"{Emberes.Average(x => x.HasznosTeher):F2} kg", $"{Emberes.Average(x => x.Koltseg):F2} mrd USD$"));
            statisztika.Add(new Statisztika("Nem emberes küldetések", NemEmberes.Count, $"{NemEmberes.Average(x => x.HasznosTeher):F2} kg", $"{NemEmberes.Average(x => x.Koltseg):F2} mrd USD$"));
            dtgDatas.ItemsSource = statisztika;
        }
    }
}
