using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GaelPic.Models
{
    public class Midia
    {
        // Atributos
        public int Id {get; set;}
        public int UserId {get; set;}
        public int TypeMidiaId {get; set;}

        [Required]
        public string Link{get; set;}

        [Display(Name = "Descrição")]
        [Required]
        public string Description{get; set;}

        [Display(Name="Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}

        // Relacionamentos
        public virtual User User {get; set;}
        public virtual TypeMidia TypeMidia {get; set;}
    }
}