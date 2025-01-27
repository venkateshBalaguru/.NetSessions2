using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    public interface ICrudable  //Exposess the behaviour of the methods 
    {
        void Create(); //Here no need public keyword because its default is public
        void Read();
        void Update();
        void Delete();
    }
}
