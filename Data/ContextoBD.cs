using TesteResoluti.Models;
using Microsoft.EntityFrameworkCore;


namespace TesteResoluti.Data
{
  public class ContextoBD : DbContext
  {
    public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
    {

    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<PessoaFisica> PessoasFisicas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Contato> Contatos { get; set; }

    //Atualizei
  }
}
