﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    
    public class Psico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        public bool IsAvailable { get; set; }
        [Required(ErrorMessage = "CRP requirido.")]
        [Display(Name = "CRP")]
        public string? CRP { get; set; }

        [Required(ErrorMessage = "Data de nascimento requerida.")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Peso requerido.")]
        [Display(Name = "Peso")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Altura requerida.")]
        [Display(Name = "Altura")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Raça requerida.")]
        [Display(Name = "Raça")]
        public Race Race { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }

    }
}