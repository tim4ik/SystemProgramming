using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Task2
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
        Process proc = new Process();
        Thread WaiterThread;
        bool started = false;
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (!started)
            {
                started = true;
                proc.StartInfo.FileName = "notepad.exe";
                proc.Start();
                WaiterThread = new Thread(new ThreadStart(ExitWaiter));
                WaiterThread.Start();
                StatusLabel.Content = "Running";
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (started)
            {
                WaiterThread.Abort();
                proc.Kill();
                StatusLabel.Content = "Exit code: " + proc.ExitCode;
                proc.Close();
                started = false;
            }
        }
        void ExitWaiter()
        {
            proc.WaitForExit();
            started = false;
            this.Dispatcher.Invoke(() => StatusLabel.Content = "Exit code: " + proc.ExitCode);
        }
    }
}
