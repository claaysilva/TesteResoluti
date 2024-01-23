using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteResoluti.Models;

public class Contato
{
  [Required]
  public int Id { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public required string Nome { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public required string Valor { get; set; }

  [Required]
  [Column(TypeName = "varchar(50)")]
  public required string Tipo { get; set; }

  public int PessoaFisicaId { get; set; }
  public required PessoaFisica PessoaFisica { get; set; }
}