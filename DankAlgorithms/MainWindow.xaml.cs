using DankAlgorithms.Algorithms;
using DankAlgorithms.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DankAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string RUNNING = "Running";
        const string COMPLETE = "Complete";

        CancellationTokenSource _cts;

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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            Stopwatch sw = new Stopwatch();
            switch (clickedButton.Name.ToLower())
            {
                case "quick":
                    break;
                case "insertion":
                    iStatus.Text = RUNNING;
                    iSortRuntime.Content = string.Empty;
                    sw.Start();
                    await InsertionSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100));
                    sw.Stop();
                    iStatus.Text = COMPLETE;
                    iSortRuntime.Content = sw.Elapsed;
                    break;
                case "evenodd":
                    eoStatus.Text = RUNNING;
                    eoSortRuntime.Content = string.Empty;
                    sw.Start();
                    await EvenOddSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100));
                    sw.Stop();
                    eoStatus.Text = COMPLETE;
                    eoSortRuntime.Content = sw.Elapsed;
                    break;
                case "bogo":
                    break;
                case "all":
                    iSortRuntime.Content = string.Empty;
                    eoSortRuntime.Content = string.Empty;
                    allRuntime.Content = string.Empty;
                    iStatus.Text = RUNNING;
                    eoStatus.Text = RUNNING;
                    allStatus.Text = RUNNING;
                    sw.Start();
                    Task inSort = InsertionSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100));
                    await inSort.ContinueWith(t =>
                     {
                         this.Dispatcher.Invoke(() =>
                         {
                             iSortRuntime.Content = sw.Elapsed;
                             iStatus.Text = COMPLETE;
                         });
                     });
                    Task eoSort = EvenOddSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100));
                    await eoSort.ContinueWith(t =>
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            eoSortRuntime.Content = sw.Elapsed;
                            eoStatus.Text = COMPLETE;
                        });
                    });
                    await Task.WhenAll(inSort, eoSort);
                    sw.Stop();
                    allRuntime.Content = sw.Elapsed;
                    allStatus.Text = COMPLETE;
                    break;
                case "cancel":
                    _cts?.Cancel();
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
