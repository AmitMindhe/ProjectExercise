using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
public class ProjectUserViewModel : BaseEntityViewModel
{
    [Display(Name = "First Name")]
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required]
    [MaxLength(255)]
    public string LastName { get; set; }

    [Display(Name = "User Name")]
    [Required]
    [MaxLength(255)]
    public string UserName { get; set; }

    [Display(Name = "Password")]
    [Required]
    [MaxLength(50)]
    public string Password { get; set; }

    [Display(Name = "Status")]
    [Required]
    [MaxLength(50)]
    public string Status { get; set; }
}

