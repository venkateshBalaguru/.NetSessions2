using System;

namespace TodoCommonLib
{
    public class Todo
    {
        private static int _id=0;
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

    }
}
