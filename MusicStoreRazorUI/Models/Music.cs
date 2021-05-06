using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreRazorUI.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }

        [Required]//Girilmesi zorunlu
        public string Name { get; set; }
        public string Author { get; set; }
        public string BarcodeNumber { get; set; }
    }
}
