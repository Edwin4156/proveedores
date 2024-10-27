using Apiempresa2.models;
using Microsoft.EntityFrameworkCore;
namespace ApiEmpresa2.models;
public class Conexiones : DbContext {
     public Conexiones (DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<Clientes> Proveedores { get; set; } = null!;
}