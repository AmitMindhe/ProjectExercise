using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
public class ContactViewModel : BaseEntityViewModel
{
    [Display(Name = "First Name")]
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required]
    [MaxLength(255)]
    public string LastName { get; set; }

    [Display(Name = "Phone Number")]
    [Required]
    public long? PhoneNumber { get; set; }

    [Display(Name = "Email Id")]
    [Required]
    [MaxLength(255)]
    public string EmailId { get; set; }

    [Display(Name = "Status")]
    [Required]
    [MaxLength(50)]
    public string Status { get; set; }
}

