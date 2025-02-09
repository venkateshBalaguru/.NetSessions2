using New_ImageToBinary.Models;
using System.Drawing;


namespace New_ImageToBinary
{
        internal class Program
        {
            static void Main(string[] args)
            {

            Image image = Image.FromFile("C:\\venkat-html-app\\DotNetSessions\\Day39\\New_ImageToBinary\\Nature.jpg");
            ImgConverter app = new ImgConverter();
                byte[] Imagedata = app.imageToByteArray(image);
                Console.WriteLine("Image Conversion is completed");

                app.byteArrayToImage(Imagedata);

                Console.WriteLine("Image generated at path ->C:\\venkat-html-app\\DotNetSessions\\Day39\\New_ImageToBinary\\");
            }
        }
    }