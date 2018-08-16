using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Core
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? Created { get; set; }
    }
}
