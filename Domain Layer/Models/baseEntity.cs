using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class baseEntity
    {
        public int Id { get; set; }
        public DateTime modfiedDate { get; set; }

        public DateTime createdDate { get; set; }
    }
}

