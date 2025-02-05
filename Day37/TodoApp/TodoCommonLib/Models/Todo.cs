using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TodoCommonLib.Models
{
    public class Todo
    {
    private static int _id = 0;
    private string _description;
    private string _priority;
    public Todo(string description, string priority)
    {
        _id++;
        _description = description;
        _priority = priority;
    }

    private int Id { get { return _id; } }
    private string Description { get { return _description; } }

    private string Priority { get { return _priority; } }

    public override string ToString()
    {
        return $"Work-To-Do : {this.Description} ==> Priority : {this.Priority}";
    }

}
}
