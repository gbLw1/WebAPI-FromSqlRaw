using base_de_dados.Context;
using base_de_dados.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace base_de_dados.Controllers;

[ApiController]
[Route("[controller]")]
public class ImobiliariaController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ImobiliariaController> _logger;
    private readonly MeuDbContext _context;

    public ImobiliariaController(
        ILogger<ImobiliariaController> logger,
        MeuDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    /// <summary>
    /// Exercício 05 - Prova Banco de Dados
    /// </summary>
    /// <remarks>
    /// Criar uma query para listar o número de imóveis locados e não locados e total imóveis por tipo. Utilizando subquery
    /// </remarks>
    /// <returns></returns>
    [HttpGet("/ex5")]
    public async Task<ActionResult<IEnumerable<LocadosNaoLocadosPorTipo>>> ImoveisLocadosENaoLocadosPorTipo()
    {
        _logger.LogInformation("Executing -> Imoveis 'Locados' e 'Não Locados' ordenados por tipo");

        StringBuilder sb = new();
        sb.AppendLine("SELECT t.Id AS 'Codigo'");
        sb.AppendLine(", t.descritivo AS 'Tipo'");
        sb.AppendLine(", (SELECT COUNT(l.Id) FROM locacao l ");
        sb.AppendLine("INNER JOIN imoveis i ON (l.ImovelId = i.Id)");
        sb.AppendLine("WHERE i.TipoId = t.Id) AS 'Locados'");
        sb.AppendLine(", (SELECT COUNT(i.Id) FROM imoveis i");
        sb.AppendLine("LEFT JOIN locacao l ON (l.ImovelId = i.Id)");
        sb.AppendLine("WHERE l.ImovelId IS NULL AND t.Id = i.TipoId) AS 'NaoLocados'");
        sb.AppendLine(", (SELECT COUNT(Id) FROM imoveis WHERE TipoId = t.Id) AS 'Total'");
        sb.AppendLine("FROM tipos t");
        sb.AppendLine("ORDER BY t.Descritivo");

        var result = await _context.Set<LocadosNaoLocadosPorTipo>()
                                   .FromSqlRaw(sb.ToString())
                                   .ToListAsync();

        return Ok(result);
    }
}