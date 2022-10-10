namespace base_de_dados.Models;

public class Proprietario
{
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Sexo { get; set; }
    public DateTime Nascimento { get; set; }
}