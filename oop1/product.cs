using System;
using System.Collections.Generic;
using System.Text;

namespace oop1
{
    class product //entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string productname { get; set; }
        public double unitprice { get; set; }
        public int unitinstock { get; set; }
        
    }
}
