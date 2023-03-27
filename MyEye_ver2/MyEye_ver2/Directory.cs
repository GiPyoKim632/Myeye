using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace MyEye_ver2
{
    public class Directory
    {

        public static ObservableCollection<string> GetVideoFiles(string path)
        {
            ObservableCollection<string> videoFiles = new ObservableCollection<string>();

            if (System.IO.Directory.Exists(path))
            {
                var files = System.IO.Directory.GetFiles(path, "*.avi");

                foreach (var file in files)
                {
                    videoFiles.Add(System.IO.Path.GetFileNameWithoutExtension(file));
                }
            }

            return videoFiles;
        }
    }
}