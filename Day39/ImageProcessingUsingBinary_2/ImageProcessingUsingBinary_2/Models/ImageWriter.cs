using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingUsingBinary_2.Models
{
    internal class ImageWriter
    {
        public void OutputImage(string outputPath, byte[] processData )
        {
            var fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
            var bw = new BinaryWriter(fs);
            bw.Write(processData);
            fs.Close();
            bw.Close();

        }
    }
}
