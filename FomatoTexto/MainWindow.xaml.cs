using System.Windows;
using System.Windows.Media;

namespace FomatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void botonAzul_Click(object sender, RoutedEventArgs e)
            => textoTrim.Foreground= Brushes.Blue;
        private void botonRojo_Click(object sender, RoutedEventArgs e)
            => textoTrim.Foreground = Brushes.Red;
        private void botonVerde_Click(object sender, RoutedEventArgs e)
            => textoTrim.Foreground = Brushes.Green;
        private void CheckBoxNegrita_Checked(object sender, RoutedEventArgs e)
             => textoTrim.FontWeight = FontWeights.Bold;
        private void CheckBoxNegrita_Unchecked(object sender, RoutedEventArgs e)
             => textoTrim.FontWeight = FontWeights.Normal;
        private void CheckBoxCursiva_Checked(object sender, RoutedEventArgs e)
            => textoTrim.FontStyle = FontStyles.Italic;
        private void CheckBoxCursiva_Unchecked(object sender, RoutedEventArgs e)
            => textoTrim.FontStyle = FontStyles.Normal;
        private void cajaFormaTexto_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
            => textoTrim.Text = cajaTexto.Text;

    }
}
