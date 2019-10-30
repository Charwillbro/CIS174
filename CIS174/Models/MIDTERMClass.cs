using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Models
{
    public class MIDTERMClass
    {

        [Required]
        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string Name { get; set; }

        [Required]
        [Range(4, 16)]
        public int RandomAccessMemory { get; set; }

        [Required]
        public float CpuSpeed { get; set; }


        [StringLength(70, ErrorMessage = "Maximum length is 70")]
        [Display(Name = "Graphics")]
        public string Graphics { get; set; }


        [EmailAddress]
        [StringLength(25, ErrorMessage = "Maximum length is 100")]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Required]
        [Url]
        [Display(Name = "WhereToBuy")]
        public string WhereToBuy { get; set; }


        [Phone]
        [Display(Name = "Phone number")]
        public string SupportPhoneNumber { get; set; }

    }
}
