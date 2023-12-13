using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoProdutos.Application.DTOs
{
    public class ProdutoDTO
    {
        public ProdutoDTO(int id, string nome, int precoDeVenda, string descricao, string tipo, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            PrecoDeVenda = precoDeVenda;
            Descricao = descricao;
            Tipo = tipo;
            DataCadastro = dataCadastro;
        }


        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Preço da Venda")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        public int PrecoDeVenda { get; set; }

        [Required(ErrorMessage = "Descriçao é Obrigatória")]
        [MinLength(5)]
        [MaxLength(200)]
        public string Descricao { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Data de Cadastro é Obrigatório")]
        public DateTime DataCadastro { get; set; }
    }
}
