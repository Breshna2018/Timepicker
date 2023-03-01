using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class Clock
    {

        string header;
        string body;
        DateTime create;
        public Clock(string header, string body, DateTime create)
        {
            this.header = header;
            this.body = body;
            this.create = create;
        }
        public override string ToString()
        {
            return $"{create.ToShortDateString()}-{header}";
        }
    }
}
