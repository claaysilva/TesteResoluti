using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TesteResoluti.Models;

public class Usuario
{
  [Required]
  public int Id { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Nome { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Email { get; set; }

  [Required]
  [Column(TypeName = "varchar(20)")]
  public string Telefone { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Senha { get; set; }

  [Required]
  public byte[] Imagem { get; set; }

  public List<PessoaFisica> PessoasFisicas { get; set; }
}
