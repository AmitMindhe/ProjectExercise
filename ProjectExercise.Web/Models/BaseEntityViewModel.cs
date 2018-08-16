using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

public class BaseEntityViewModel
{
    public int Id { get; set; }

    [Display(Name = "Modified By")]
    public int? ModifiedBy { get; set; }

    [Display(Name = "Modified On")]
    public DateTime? Modified { get; set; }

    [Display(Name = "Created By")]
    public int? CreatedBy { get; set; }

    [Display(Name = "Created On")]
    public DateTime? Created { get; set; }
}