using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baraja_RubindeCelis.Models
{
    public class Baraja
    {
        [Key]
        [Required] // Sea obligatorio
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Por favor ingrese una sola letra")]
        [Display(Name = "Inserte letra de la A a la K")]
        public string IdNaipe { get; set; } //escribir prop y tab tab para que se cree automaticamente

        [Required] // Sea obligatorio
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Por favor ingrese entre 2 y 60 caracteres")]
        [Display(Name = "Nombre de la carta")]
        public string NombreNaipe { get; set; } //escribir prop y tab tab para que se cree automaticamente

        [Url]
        [Required] // Sea obligatorio
        [StringLength(300, MinimumLength = 2, ErrorMessage = "Por favor ingrese entre 2 y 300 caracteres")]
        [Display(Name = "Link de la carta")]
        public string LinkNaipe { get; set; } //escribir prop y tab tab para que se cree automaticamente
    }
}
