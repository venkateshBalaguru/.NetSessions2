using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute_2.Models
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class ThisNeedAttentionAttribute : Attribute
    {
        public string Message { get; set; }
        
        public ThisNeedAttentionAttribute(string  message)
        {
            this.Message = message;
        }
    }
}
