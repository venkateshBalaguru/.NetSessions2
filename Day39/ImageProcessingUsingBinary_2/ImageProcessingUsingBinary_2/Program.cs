using ImageProcessingUsingBinary_2.Models;

namespace ImageProcessingUsingBinary_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imagePath = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinary_2\Nature.jpg";
            string OutputImagePath = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinary_2\Output_Nature.jpg";

            ImageReader imagereader = new ImageReader();
            byte[] imageData = imagereader.ReadImage(imagePath);

            ImageProcessor imageprocessor = new ImageProcessor();
            byte[] halfImage = imageprocessor.ProcessData(imageData);

            ImageWriter imageWriter = new ImageWriter();
            imageWriter.OutputImage(OutputImagePath, halfImage);

            Console.WriteLine($"The Image was processed and written in the Path: {OutputImagePath}");

        }
    }
}
