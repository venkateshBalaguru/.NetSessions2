using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingUsingBinary_2.Models
{
    internal class ImageReader
    {
        public byte[] ReadImage(string imagePath)
        {
            var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            //Console.WriteLine(fs.Length);
            byte[] data = new byte[fs.Length];
            // Console.WriteLine(data.Length);
            fs.Close();
            fs.Close();
            return data;
        }
    }
}
