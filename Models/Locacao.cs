using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.Models
{
    [Table("locacao")]
    public class Locacao
    {

        [Key]
        [Column("locacao_cod")]
        public Int32 Locacao_Cod { get; set; }
        [Column("auto_cod")]
        public Int32 Auto_cod { get; set; }
        [Column("cliente_cod")]
        public Int32 Cliente_Cod { get; set; }
        [Column("locacao_km")]
        public Int32 Locacao_Km { get; set; }
        [Column("dt_cadastro")]
        public DateTime Dt_Cadastro { get; set; }

    }
}
