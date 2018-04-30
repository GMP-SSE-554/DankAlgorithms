using System.Windows;
using System.Windows.Controls;

namespace DankAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AlgorithmSet _algorithmSet = new AlgorithmSet();
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _algorithmSet;
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            switch (clickedButton.Name)
            {
                case "quick":
                    break;
                case "insertion":
                    break;
                case "bubble":
                    break;
                case "bogo":
                    break;
                default:
                    break;
            }
        }
    }
}
