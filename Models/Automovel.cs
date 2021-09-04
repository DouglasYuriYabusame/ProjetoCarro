using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.Models
{
    [Table("automovel")]
    public class Automovel
    {

        [Key]
        [Column("auto_cod")]
        public Int32 Auto_Cod { get; set; }

        [Column("marca_cod")]
        public Int32 Marca_Cod { get; set; }

        [Column("modelo_cod")]
        public Int32 Modelo_Cod { get; set; }

        [Column("auto_nome")]
        public String Auto_Nome { get; set; }

    }
}
