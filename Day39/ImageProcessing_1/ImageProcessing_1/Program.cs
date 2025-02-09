namespace ImageProcessing_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imagePath = "C:\\venkat-html-app\\DotNetSessions\\Day39\\ImageProcessing_1\\Nature.jpg";
            string outputPath = "C:\\venkat-html-app\\DotNetSessions\\Day39\\ImageProcessing_1\\output_Nature.jpg";

            FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] imageBytes = new byte[fs.Length];
            fs.Read(imageBytes, 0, imageBytes.Length);
            fs.Close();

            int halfLength = imageBytes.Length/ 2;
            MemoryStream ms = new MemoryStream(imageBytes);
            BinaryReader br = new BinaryReader(ms);
            byte[] halfArray = br.ReadBytes(halfLength);
            br.Close();
            ms.Close();

            FileStream fs1 = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs1);
            bw.Write(halfArray);
            bw.Close();
            fs1.Close();
           

            Console.WriteLine("Image processing complete. Half of the image bytes written to: " + outputPath);

        }
    }
}
