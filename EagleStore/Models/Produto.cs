using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EagleStore.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey(nameof(CategoriaId))]
    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    [StringLength(1000, ErrorMessage = "O nome deve possuir no máximo 1000 caracteres")]
    public string Descricao { get; set; }


    public int Qtde { get; set; }

    public decimal ValorCusto { get; set; }

    public decimal ValorVenda { get; set; }
    
}