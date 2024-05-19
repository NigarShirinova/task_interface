using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    internal class Grade
    {
        public string Subject { get; set; }
        public Degree Degree { get; set; }

        public Grade(string subject, Degree degree)
        {
            Subject = subject;
            Degree = degree;
        }

        
    }
}
