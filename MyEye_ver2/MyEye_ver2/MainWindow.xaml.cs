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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyEye_ver2
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

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
            //Main 버튼 클릭 시 처리할 내용 작성
        }

        private void AnalysisButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Uri("Analysis.xaml", UriKind.Relative));
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Uri("Replay.xaml", UriKind.Relative));
        }
    }

    
}
