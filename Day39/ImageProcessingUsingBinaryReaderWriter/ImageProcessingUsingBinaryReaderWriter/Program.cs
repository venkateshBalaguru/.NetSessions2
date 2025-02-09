using static System.Net.Mime.MediaTypeNames;
namespace ImageProcessingUsingBinaryReaderWriter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            String inputImage = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinaryReaderWriter\Nature.jpg"; ;
            String outPutImage = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinaryReaderWriter\Output_Nature.jpg";

            //Read the entire image file into a byte array
            byte[] imageData;

            using (FileStream fs = new FileStream(inputImage, FileMode.Open, FileAccess.Read ))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    imageData = new byte[fs.Length];
                    //Console.WriteLine(imageData.Length);
                    br.Read(imageData, 0, (int)fs.Length);
                }
            }

            // Calculate half of the array length
            int halfLength = imageData.Length / 2;

            // Write only half of the array to a new file
            using (FileStream fsOut = new FileStream(outPutImage, FileMode.Create,FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fsOut))
                {
                    bw.Write(imageData, 0, halfLength);

                }
            }

            Console.WriteLine("Half of the image data has been written to the output file.");
        }


    }
}

