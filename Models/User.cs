using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaelPic.Models
{
    public class User
    {
        // Atributos
        public int Id {get; set;}

        [Display(Name = "Nome")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Name{get; set;}

        [Required]
        public string Email{get; set;}

        [Display(Name = "Celular")]
        [StringLength(11, MinimumLength = 11)]
        [Required]
        public string Fone{get; set;}

        [Display(Name = "Senha")]
        [Required]
        public string Password{get; set;}

        // Relacionamentos
        public virtual ICollection<Midia> Midias {get; set;}
    }
}