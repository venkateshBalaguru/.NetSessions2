using CompositeDesignPattern_FilesForlders;
using System;
using System.Collections.Generic;
using System.IO;

namespace CompositeDesignPattern_FilesForlders
{
    class Program
    {
        static void Main()
        {
            string filePath = "C:\venkat-html-app\\DotNetSessions\\Day50\\CompositeDesignPattern_MenuHierarchy\\MenuHierarchyBuilder.txt";
            //char charToTrim = '\'';
            List<Composite> compdata = new List<Composite>();  //using HashSet for getting the unique values


            //Reading the file 
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
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
                        var empId = Convert.ToInt32(values[i]);
                        compdata.Add(new Leaf(_name));
                    }
                }
                sr.Close();
            }
            //    string[] lines = File.ReadAllLines("New_Menu.txt");
            //    Stack<Composite> stack = new Stack<Composite>();
            //    Composite root = null;

            //    foreach (string line in lines)
            //    {
            //        int indentLevel = line.TakeWhile(char.IsWhiteSpace).Count();
            //        string name = line.Trim();

            //        var component = new Composite(name);

            //        if (indentLevel == 0)
            //        {
            //            root = component;
            //            stack.Push(root);
            //        }
            //        else
            //        {
            //            while (stack.Count > indentLevel)
            //            {
            //                stack.Pop();
            //            }

            //            stack.Peek().Add(component);
            //            stack.Push(component);
            //        }
            //    }

            //    root?.Display();
        }
    }
}
