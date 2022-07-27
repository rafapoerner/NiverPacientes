using Microsoft.EntityFrameworkCore;
using Pacientes.API.Models;

public class DataContext : DbContext{
    public DbSet<Paciente> Pacientes => Set<Paciente>();

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Paciente>()
        .Property(p => p.Nome).HasMaxLength(120).IsRequired();
        builder.Entity<Paciente>()
        .Property(p => p.Telefone).HasMaxLength(20).IsRequired();
        builder.Entity<Paciente>()
        .Property(p => p.DataNasc).HasMaxLength(20);
    }
}