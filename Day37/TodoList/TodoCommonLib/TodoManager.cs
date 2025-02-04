using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCommonLib
{
    public class TodoManager
    {
        //private List<Todo> _todo = new List<Todo>();
         

    public static void AddTodoList(string desc, string prioritize)
        {
          List<Todo> list = new List<Todo>();
            list.Add(new(new(desc), prioritize));

        }

        public static void DisplayTodoList()
        {
  
        }
    }
}
