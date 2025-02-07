using static System.Net.Mime.MediaTypeNames;
namespace ImageProcessingUsingBinaryReaderWriter
{
    

        internal class Program
        {
            static void Main(string[] args)
            {
                String inputImage = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinaryReaderWriter\Nature.jpg";
                String outPutImage = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinaryReaderWriter\Output_Nature.jpg";

                byte[] imageFile; //getting the data from the image by using byte array

                FileStream fs = new FileStream(inputImage, FileMode.Open); //Open the image file using filestream

                BinaryReader br = new BinaryReader(fs); //Processing the image by binary reader
                imageFile = new byte[fs.Length];
                //Console.WriteLine(imageFile.Length);
                br.Read(imageFile, 0, (int)fs.Length);
                br.Close();
                fs.Close();

                int cutImage = imageFile.Length / 4; //divide the length to get the half image

                FileStream fsOutput = new FileStream(outPutImage, FileMode.Create); //creating the image with the half length of height
                BinaryWriter bw = new BinaryWriter(fsOutput);
                bw.Write(imageFile, 0, cutImage);
                bw.Close();
                fsOutput.Close();  
                Console.WriteLine("Image created in the output path....");
            }
        }
    }