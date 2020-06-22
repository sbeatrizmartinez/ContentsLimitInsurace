using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentsLimitInsurace.Models
{
    public class ContentLimit
    {
        [Key]
        public int ContentId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string itemName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public float itemValue { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string itemCategory { get; set; }

    }
}