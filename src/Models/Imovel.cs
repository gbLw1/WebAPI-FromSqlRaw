namespace base_de_dados.Models;

public class Imovel
{
    public Guid Id { get; set; }
    public string? Descritivo { get; set; }
    public string? Estado { get; set; }
    public double Aluguel { get; set; }
    public DateTime DataCadastro { get; set; }


    public Guid TipoId { get; set; }
    public Tipo? Tipo { get; set; }

    public Guid ProprietarioId { get; set; }
    public Proprietario? Proprietario { get; set; }
}