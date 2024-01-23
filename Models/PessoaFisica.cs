using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteResoluti.Models;

public class PessoaFisica
{
  [Required]
  public int Id { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Nome { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(255)")]
  public string Sobrenome { get; set; }

  [Required]
  public DateTime DataNascimento { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(14)")]
  public string CPF { get; set; }

  [Required]
  [Column(TypeName = "VARCHAR(20)")]
  public string RG { get; set; }

  public int UsuarioId { get; set; }
  public Usuario Usuario { get; set; }

  public List<Endereco> Enderecos { get; set; }
  public List<Contato> Contatos { get; set; }
}
