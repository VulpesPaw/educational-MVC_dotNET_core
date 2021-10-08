using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteMaster.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Quotes { get; set; }
        public string  Authors { get; set; }

        public Quote()
        {

        }
    }
}
