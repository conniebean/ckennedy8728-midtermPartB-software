using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ckennedy8728_midtermPartB_software.Models
{
    public class User
    {
        [Required(ErrorMessage = "You must enter your name to continue on your journey")]
        [Range(4, 10, ErrorMessage = "Your name must be at least 4 characters but no more than 10.")]
        public string UserName { get; set; }
    }
}
