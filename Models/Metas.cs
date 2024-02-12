﻿using System.ComponentModel.DataAnnotations;

namespace Parcial1_AP1_EliezerTerrero.Models
{
    public class Metas
    {
        [Key]
        public int MetaId { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El monto es requerido")]
        public decimal Monto { get; set; }
    }
}
