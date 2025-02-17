using CompositeDesignPattern_FilesForlders.Models;
using System;

namespace CompositeDesignPattern_FilesForlders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create files
            Files file1 = new Files("File1.txt");
            Files file2 = new Files("File2.txt");
            Files file3 = new Files("File3.txt");
            Files file4 = new Files("File4.txt");

            // Create folders
            Folder root = new Folder("Root");
            Folder subFolder1 = new Folder("SubFolder1");
            Folder subFolder2 = new Folder("SubFolder2");

            // Compose the tree structure
            root.Add(file1);
            root.Add(subFolder1);
            subFolder1.Add(file2);
            subFolder1.Add(file4);
            subFolder1.Add(subFolder2);
            subFolder2.Add(file3);

            // Display the structure
            root.Display(1);
        }
    }
}
