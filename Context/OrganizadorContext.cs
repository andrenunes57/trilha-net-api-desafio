using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context;

public class OrganizadorContext(DbContextOptions<OrganizadorContext> options) : DbContext(options)
{
    public DbSet<Tarefa> Tarefas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefa>()
            .HasKey(t => t.Id);

        modelBuilder.Entity<Tarefa>()
            .Property(t => t.Titulo)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<Tarefa>()
            .Property(t => t.Descricao)
            .HasMaxLength(500);
    }
}