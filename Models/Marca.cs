using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.Models
{
    [Table("marca")]
    public class Marca
    {

        [Key] // chave primaria
        [Column("marca_cod")]  // nome da coluna no banco de dados
        public Int32 Marca_Cod { get; set; }

        [Column("marca_desc")]
        public String Marca_Desc { get; set; }

    }
}
