using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureApp.Models
{
    public class Entry
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Chapter { get; set; }
       

        [Range(1, 400)]
        public int Verse { get; set; }
        

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        [StringLength(1600, MinimumLength = 3)]
        [Required]
        public string Thoughts { get; set; }


    }
}
