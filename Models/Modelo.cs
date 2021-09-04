using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.Models
{
    [Table("modelo")]
    public class Modelo
    {

        [Key] // chave primaria
        [Column("modelo_cod")]  // nome da coluna no banco de dados
        public Int32 Modelo_Cod { get; set; }

        [Column("modelo_desc")]
        public String Modelo_Desc { get; set; }
    }
}
