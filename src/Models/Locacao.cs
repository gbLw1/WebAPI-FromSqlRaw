namespace base_de_dados.Models;

public class Locacao
{
    public Guid Id { get; set; }
    public DateTime DataLocacao { get; set; }


    public Guid InquilinoId { get; set; }
    public Inquilino? Inquilino { get; set; }

    public Guid ImovelId { get; set; }
    public Imovel? Imovel { get; set; }
}