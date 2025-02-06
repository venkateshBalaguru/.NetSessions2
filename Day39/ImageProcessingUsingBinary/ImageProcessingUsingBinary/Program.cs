using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

 static void CropImageHalf(string sourceImagePath, string destinationImagePath, bool cropLeftHalf)
{
    try
    {
        using (Image<Rgba32> image = Image.Load<Rgba32>(sourceImagePath))
        {
            int width = image.Width;
            int height = image.Height;

            Rectangle cropArea;
            if (cropLeftHalf)
            {
                cropArea = new Rectangle(0, 0, width, height/2); // Left half
            }
            else
            {
                cropArea = new Rectangle(width, 0, width, height); // Right half
            }

            image.Mutate(x => x.Crop(cropArea));
            image.Save(destinationImagePath); // Save the cropped image
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

// Example usage:
string sourceImage = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinary\Nature.jpg";
string destinationImage = @"C:\venkat-html-app\DotNetSessions\Day39\ImageProcessingUsingBinary\OutputImage\Nature.jpg";
CropImageHalf(sourceImage, destinationImage, true); // Crop left half

// To display in a PictureBox (WinForms):
// pictureBox1.Image = Image.FromFile(destinationImage);