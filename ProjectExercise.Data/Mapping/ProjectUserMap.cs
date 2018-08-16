using ProjectExercise.Core.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Data.Mapping
{
    public class ProjectUserMap : EntityTypeConfiguration<ProjectUser>
    {
        public ProjectUserMap()
        {
            ToTable("ProjectUser");

            HasKey(s => s.Id);
        }
    }
}
