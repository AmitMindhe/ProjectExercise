using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Core.Common
{
    public class Contact : BaseEntity
    {
        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        public long? PhoneNumber { get; set; }

        [MaxLength(255)]
        public string EmailId { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

    }

}
