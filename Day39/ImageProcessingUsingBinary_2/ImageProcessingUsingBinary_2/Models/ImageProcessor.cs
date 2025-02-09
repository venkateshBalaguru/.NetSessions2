using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingUsingBinary_2.Models
{
    internal class ImageProcessor
    {
        public byte[] ProcessData(byte[] imagedata)
        {
            int halfLength = imagedata.Length / 2;
            MemoryStream ms = new MemoryStream(imagedata);
            BinaryReader br = new BinaryReader(ms);
            byte[] halfArray = br.ReadBytes(halfLength);
            br.Close();
            ms.Close();
            return halfArray;
        }
    }
}
