using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaelPic.Models
{
    public class TypeMidia
    {
        // Atributos
        public int Id {get; set;}

        [Display(Name = "Descrição")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Description{get; set;}

        // Relacionamentos
        public virtual ICollection<Midia> Midias {get; set;}
    }
    

}