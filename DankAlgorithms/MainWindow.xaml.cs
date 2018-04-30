using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DankAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int DatasetSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            AddDataSetSizes();
            DataContext = this;
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
                case "evenodd":
                    break;
                case "bogo":
                    break;
                default:
                    break;
            }
        }

        private void AddDataSetSizes()
        {
            List<int> datasetSizes = new List<int>();
            for (int i = 1; i < 9; i++)
            {
                datasetSizes.Add((int)System.Math.Pow(10, i));
            }
            DatasetSizes.ItemsSource = datasetSizes;
            DatasetSizes.SelectedIndex = 0;
        }
    }
}
