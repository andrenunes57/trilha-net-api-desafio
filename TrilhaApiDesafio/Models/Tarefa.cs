using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrilhaApiDesafio.Models;

public class Tarefa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Titulo { get; set; } = null!;
    
    [StringLength(500)]
    public string? Descricao { get; set; }

    [Required]
    public DateTime Data { get; set; }

    [Required]
    public EnumStatusTarefa Status { get; set; }
}