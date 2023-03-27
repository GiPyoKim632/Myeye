using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyEye_ver2
{
    public class ViewModel
    {
        public ObservableCollection<string> Videos { get; set; }

        public ViewModel()
        {
            Videos = Directory.GetVideoFiles("C:\\Users\\김기표\\source\\repos\\MyEye_ver2\\MyEye_ver2").Count > 0 ? Directory.GetVideoFiles("C:\\Users\\김기표\\source\\repos\\MyEye_ver2\\MyEye_ver2") : new ObservableCollection<string> { "No videos found." };
        }
    }
}
