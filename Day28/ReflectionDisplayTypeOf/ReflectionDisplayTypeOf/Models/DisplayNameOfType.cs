using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDisplayTypeOf.Models
{
    public class DisplayNameOfType
    {
        public static void DoReflection(Type type)
        {
            Console.WriteLine($"Class Name ==> {type.Name}\n======================");

            Console.Write($"Constructors\n-------------- \nCount: {type.GetConstructors().Length}\nName : ");
            foreach (ConstructorInfo name in type.GetConstructors())
            {
                Console.Write($"{name.Name} | ");
            }

            Console.Write($"\n\nMethods\n-------------- \nCount : {type.GetMethods().Length}\nName : ");
            foreach (MethodInfo name in type.GetMethods())
            {
                Console.Write($"{name.Name} | ");
            }

            Console.Write($"\n\nProperties\n-------------- \nCount : {type.GetProperties().Length}\nName : ");
            foreach (PropertyInfo name in type.GetProperties())
            {
                Console.Write($"{name.Name} | ");
            }
            Console.Write($"\n\nFields\n-------------- \nCount : {type.GetFields().Length}\nName : ");
            foreach (FieldInfo name in type.GetFields())
            {
                Console.Write($"{name.Name} | \n========================");
            }
            
        }

        }
    }
