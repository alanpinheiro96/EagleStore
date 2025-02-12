using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EagleStore.Models;

[Table("Produto")]
public class Produto
{
    public int Id { get; set; }

    public Categoria CategoriaId { get; set; }

    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int Qtde { get; set; }

    public decimal ValorCusto { get; set; }

    public decimal ValorVenda { get; set; }
    
}