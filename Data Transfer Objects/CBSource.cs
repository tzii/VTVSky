using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class CBSource
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public CBSource() { }
        public CBSource(string _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
    }
}
