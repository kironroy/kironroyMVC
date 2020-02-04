using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KironRoyMVC.Models
{
        
    [Authorize]
    public class MessageModel
    {
     
        [Required]
        [StringLength(20, MinimumLength = 5)]
        [Display(Name = "Developer Message")]
        public string Message { get; set; }
    }
}
