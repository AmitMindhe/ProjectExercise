using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Core
{
    public class ErrorLog : BaseEntity
    {
        public string Message { get; set; }

        public string Details { get; set; }
    }
}
