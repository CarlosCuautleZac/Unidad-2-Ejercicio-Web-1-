using System;
using System.Collections.Generic;

namespace Unidad2ProgramacionWeb.Models
{
    public partial class Estado
    {
        public int Id { get; set; }
        /// <summary>
        /// NOM_ENT - Nombre de la entidad
        /// </summary>
        public string Nombre { get; set; } = null!;
        /// <summary>
        /// NOM_ABR - Nombre abreviado de la entidad
        /// </summary>
        public string Abrev { get; set; } = null!;
    }
}
