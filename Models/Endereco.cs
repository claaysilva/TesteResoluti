using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteResoluti.Models;

public class Endereco
{
  [Required]
  public int Id { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Logradouro { get; set; }

  [Required]
  [Column(TypeName = "varchar(20)")]
  public string Numero { get; set; }

  [Required]
  [Column(TypeName = "varchar(10)")]
  public string CEP { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Complemento { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Cidade { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Estado { get; set; }

  public int PessoaFisicaId { get; set; }
  public PessoaFisica PessoaFisica { get; set; }
}