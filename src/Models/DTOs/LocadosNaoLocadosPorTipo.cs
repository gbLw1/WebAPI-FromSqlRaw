using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace base_de_dados.Models.DTOs;

public class LocadosNaoLocadosPorTipo
{
    public Guid Codigo { get; set; }
    public string? Tipo { get; set; }
    public int Locados { get; set; }
    public int NaoLocados { get; set; }
    public int Total { get; set; }
}

public class LocadosNaoLocadosPorTipoTypeConfiguration :
    IEntityTypeConfiguration<LocadosNaoLocadosPorTipo>
{
    public void Configure(EntityTypeBuilder<LocadosNaoLocadosPorTipo> builder)
    {
        builder
            .HasKey(p => p.Codigo);
    }
}