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
        const string CANCELED = "CANCELED";

        CancellationTokenSource _cts = new CancellationTokenSource();

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
                    await InsertionSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    sw.Stop();
                    iStatus.Text = COMPLETE;
                    iSortRuntime.Content = sw.Elapsed;
                    break;
                case "evenodd":
                    eoStatus.Text = RUNNING;
                    eoSortRuntime.Content = string.Empty;
                    sw.Start();
                    await EvenOddSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    sw.Stop();
                    eoStatus.Text = COMPLETE;
                    eoSortRuntime.Content = sw.Elapsed;
                    break;
                case "arrayadd":
                    arrayAddStatus.Text = RUNNING;
                    arrayAddRuntime.Content = string.Empty;
                    sw.Start();
                    await ArrayAddition.AddArraysAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100),
                        RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    sw.Stop();
                    arrayAddStatus.Text = COMPLETE;
                    arrayAddRuntime.Content = sw.Elapsed;
                    break;
                case "arraysum":
                    arraySumStatus.Text = RUNNING;
                    arraySumRuntime.Content = string.Empty;
                    sw.Start();
                    await ArraySum.SumAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    sw.Stop();
                    arraySumStatus.Text = COMPLETE;
                    arraySumRuntime.Content = sw.Elapsed;
                    break;
                case "parrayadd":
                    pArrayAddStatus.Text = RUNNING;
                    pArrayAddRuntime.Content = string.Empty;
                    sw.Start();
                    await ParallelArrayAddition.AddArraysAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100),
                        RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    sw.Stop();
                    pArrayAddStatus.Text = COMPLETE;
                    pArrayAddRuntime.Content = sw.Elapsed;
                    break;
                case "psum":
                    pSumStatus.Text = RUNNING;
                    pSumRuntime.Content = string.Empty;
                    sw.Start();
                    await ParallelSum.SumAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    sw.Stop();
                    pSumStatus.Text = COMPLETE;
                    pSumRuntime.Content = sw.Elapsed;
                    break;
                case "reduct":
                    reductStatus.Text = RUNNING;
                    reductRuntime.Content = string.Empty;
                    sw.Start();
                    await ReductionSum.SumAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100));
                    sw.Stop();
                    reductStatus.Text = COMPLETE;
                    reductRuntime.Content = sw.Elapsed;
                    break;
                case "all":
                    iSortRuntime.Content = string.Empty;
                    eoSortRuntime.Content = string.Empty;
                    arrayAddRuntime.Content = string.Empty;
                    arraySumRuntime.Content = string.Empty;
                    pArrayAddRuntime.Content = string.Empty;
                    pSumRuntime.Content = string.Empty;
                    allRuntime.Content = string.Empty;
                    iStatus.Text = RUNNING;
                    eoStatus.Text = RUNNING;
                    arrayAddStatus.Text = RUNNING;
                    arraySumStatus.Text = RUNNING;
                    pArrayAddStatus.Text = RUNNING;
                    pSumStatus.Text = RUNNING;
                    allStatus.Text = RUNNING;
                    sw.Start();
                    Task inSort = InsertionSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    Task eoSort = EvenOddSort.SortAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    Task arrAdd = ArrayAddition.AddArraysAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100),
                        RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    Task arrSum = ArraySum.SumAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    Task parAdd = ParallelArrayAddition.AddArraysAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100),
                        RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    Task parSum = ParallelSum.SumAsync(RandomArray.GetRandomArray(DatasetSize, 0, 100), _cts);
                    await inSort.ContinueWith(t =>
                     {
                         this.Dispatcher.Invoke(() =>
                         {
                             iStatus.Text = COMPLETE;
                         });
                     });
                    await eoSort.ContinueWith(t =>
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            eoStatus.Text = COMPLETE;
                        });
                    });
                    await arrAdd.ContinueWith(t =>
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            arrayAddStatus.Text = COMPLETE;
                        });
                    });
                    await arrSum.ContinueWith(t =>
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            arraySumStatus.Text = COMPLETE;
                        });
                    });
                    await parAdd.ContinueWith(t =>
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            pArrayAddStatus.Text = COMPLETE;
                        });
                    });
                    await parSum.ContinueWith(t =>
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            pSumStatus.Text = COMPLETE;
                        });
                    });
                    await Task.WhenAll(inSort, eoSort);
                    sw.Stop();
                    allRuntime.Content = sw.Elapsed;
                    allStatus.Text = COMPLETE;
                    break;
                case "cancel":
                    _cts?.Cancel();
                    _cts = new CancellationTokenSource();
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
