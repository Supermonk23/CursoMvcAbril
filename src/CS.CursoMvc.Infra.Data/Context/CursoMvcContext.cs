using System.Data.Entity;
using CS.CursoMvc.Domain;


namespace CS.CursoMvc.Infra.Data.Context
{
    class CursoMvcContext : DbContext
    {
        public CursoMvcContext()
            //:base("DefaultConnection")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
