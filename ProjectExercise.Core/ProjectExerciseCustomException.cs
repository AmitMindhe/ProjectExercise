using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Core
{
    public class ProjectExerciseCustomException : Exception
    {
         public ProjectExerciseCustomException(string message) : base(message) { }
         public ProjectExerciseCustomException(string message, Exception ex) : base(message, ex) { }
 
    }
}
