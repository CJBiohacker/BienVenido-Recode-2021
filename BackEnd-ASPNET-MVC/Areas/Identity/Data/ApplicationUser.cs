using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(Order = 1)]
        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }

        [PersonalData]
        [Column(Order = 2)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNasc { get; set; }

        [PersonalData]
        [Column(Order = 3)]
        [MaxLength(50)]
        [Required]
        public string Nacionalidade { get; set; }

        [PersonalData]
        [Column(Order = 4)]
        [MaxLength(30)]
        [Required]
        public string Escolaridade { get; set; }

        [PersonalData]
        [Column(Order = 5)]
        [Required]
        public ushort Filhos { get; set; }

    }
}
