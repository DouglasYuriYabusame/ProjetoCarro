using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.Models
{
    [Table("cliente")]
    public class Cliente
    {

        [Key] // chave primaria
        [Column("cliente_cod")]  // nome da coluna no banco de dados
        public Int32 Cliente_Cod { get; set; }

        [Column("cliente_nome")]
        public String Cliente_Nome { get; set; }

        [Column("cliente_email")]
        public String Cliente_Email { get; set; }

        [Column("cliente_cpf")]
        public String Cliente_Cpf { get; set; }

        [Column("cliente_endereco")]
        public String Cliente_Endereco { get; set; }

        [Column("cliente_numero")]
        public String Cliente_Numero { get; set; }

        [Column("cliente_complemento")]
        public String Cliente_Complemento { get; set; }

        [Column("cliente_cidade")]
        public String Cliente_Cidade { get; set; }

        [Column("cliente_estado")]
        public String Cliente_Estado { get; set; }

        [Column("dt_cadastro")]
        public DateTime Dt_Cadastro { get; set; }

    }
}
