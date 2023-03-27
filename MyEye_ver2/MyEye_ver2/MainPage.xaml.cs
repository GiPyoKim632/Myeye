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
using System.IO;

namespace MyEye_ver2
{
    /// <summary>
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "C:\\Users\\김기표\\source\\repos\\MyEye_ver2\\MyEye_ver2\\test.avi";
            string filePath2 = "C:\\Users\\김기표\\source\\repos\\MyEye_ver2\\MyEye_ver2\\test2.avi";

            if (File.Exists(filePath))
            {
                mediaElement.Source = new Uri(filePath);
                mediaElement.LoadedBehavior = MediaState.Manual;
                mediaElement.UnloadedBehavior = MediaState.Manual;
                mediaElement.Play();
                mediaElement2.Source = new Uri(filePath2);
                mediaElement2.LoadedBehavior = MediaState.Manual;
                mediaElement2.UnloadedBehavior = MediaState.Manual;
                mediaElement2.Play();
            }
            else
            {
                MessageBox.Show("영상이 없습니다!");
            }
        }

        



    }
}
