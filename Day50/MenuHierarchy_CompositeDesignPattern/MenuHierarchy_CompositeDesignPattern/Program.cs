using System.ComponentModel;
using MenuHierarchy_CompositeDesignPattern.Models;
using IComponent = MenuHierarchy_CompositeDesignPattern.Models.IComponent;

namespace MenuHierarchy_CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\venkat-html-app\\DotNetSessions\\Day50\\MenuHierarchy_CompositeDesignPattern\\MenuHierarchyBuilder.txt";
            //char charToTrim = '\'';
            List<IComponent> productData = new List<IComponent>();  //using list for getting the  values


            //Reading the file 
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                //var name = line.Trim();
               //var component = new Composite(name);
                bool isFirstLine = true;  //For Ignoring the first line
                //Iterating until null
                while ((line = sr.ReadLine()) != null)
                {
                    //First line caption was removing and inserting the remaining lines
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }
                    string[] values = line.Split(',');
                    for (int i = 0; i < 1; i++)
                    {
                        var product = values[i];
                        productData.Add(new Composite($"product : {values[2]}"));
                        Console.WriteLine(values[2]);
                        Console.WriteLine(values);
                    }
                }
                sr.Close();
            }
            Console.WriteLine("Details of the Employees\n==========================");
            foreach (var value in productData)
            {
                //Console.WriteLine(value);
            }
            //
        }
    }
}
