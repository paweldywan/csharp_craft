using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craft.Tests
{
    public class Account
    {
        public DateTime DueDate { get; set; }
        public Customer Customer { get; set; }
        public double Balance { get; set; }
    }
}
