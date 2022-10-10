using base_de_dados.Models;
using base_de_dados.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace base_de_dados.Context;

public class MeuDbContext : DbContext
{
    public DbSet<Imovel> Imoveis { get; set; }
    public DbSet<Inquilino> Inquilinos { get; set; }
    public DbSet<Locacao> Locacao { get; set; }
    public DbSet<Proprietario> Proprietarios { get; set; }
    public DbSet<Tipo> Tipos { get; set; }
    public DbSet<LocadosNaoLocadosPorTipo> LocadosNaoLocadosPorTipo { get; set; }

    public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
    {
        Imoveis = Set<Imovel>();
        Inquilinos = Set<Inquilino>();
        Locacao = Set<Locacao>();
        Proprietarios = Set<Proprietario>();
        Tipos = Set<Tipo>();
        LocadosNaoLocadosPorTipo = Set<LocadosNaoLocadosPorTipo>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(assembly: GetType().Assembly);

        // Inquilinos
        modelBuilder.Entity<Inquilino>().HasData(new List<Inquilino>
        {
            new Inquilino // 1
            {
                Id = Guid.Parse("a5533bd8-f1a6-42a5-839f-63f6b55f47f8"),
                Nome = "Jose",
                Sexo = "M"
            },
            new Inquilino // 2
            {
                Id = Guid.Parse("4a6fe6d2-693a-4e4b-8bbf-b6a9169ec169"),
                Nome = "João",
                Sexo = "M"
            },
            new Inquilino // 3
            {
                Id = Guid.Parse("97d2dd37-fbaf-4d8e-b618-003e20dbdbb7"),
                Nome = "Maria",
                Sexo = "F"
            },
            new Inquilino // 4
            {
                Id = Guid.Parse("5f2c27f5-d24e-41c2-8322-50ed3bb0d5d2"),
                Nome = "Rute",
                Sexo = "F"
            },
            new Inquilino // 5
            {
                Id = Guid.Parse("f5ffaafc-beae-4b0f-a53c-b0947348fb88"),
                Nome = "Manoel",
                Sexo = "M"
            },
            new Inquilino // 6
            {
                Id = Guid.Parse("1bbf3fb8-f669-47d7-a390-967034f34c26"),
                Nome = "Antonio",
                Sexo = "M"
            },
        });

        // Proprietarios
        modelBuilder.Entity<Proprietario>().HasData(new List<Proprietario>
        {
            new Proprietario // 1
            {
                Id = Guid.Parse("65209a0d-2263-41a1-a277-e5abd00fa220"),
                Nome = "wdson",
                Sexo = "M",
                Nascimento = DateTime.Now.AddYears(-20)
            },
            new Proprietario // 2
            {
                Id = Guid.Parse("04c4e003-a194-4d96-ad3f-057c59fe34bc"),
                Nome = "lucas",
                Sexo = "M",
                Nascimento = DateTime.Now.AddYears(-20)
            },
            new Proprietario // 3
            {
                Id = Guid.Parse("53945e77-7c5e-46f3-827c-8174d4a26794"),
                Nome = "patricia",
                Sexo = "F",
                Nascimento = DateTime.Now.AddYears(-20)
            },
            new Proprietario // 4
            {
                Id = Guid.Parse("38463aaa-e9d0-44ac-b7aa-0399465103a7"),
                Nome = "gabriel",
                Sexo = "M",
                Nascimento = DateTime.Now.AddYears(-20)
            },
            new Proprietario // 5
            {
                Id = Guid.Parse("951c32cf-f8a8-4048-addc-567e88a24d88"),
                Nome = "cação",
                Sexo = "M",
                Nascimento = DateTime.Now.AddYears(-20)
            },
        });

        // Tipos
        modelBuilder.Entity<Tipo>().HasData(new List<Tipo>
        {
            new Tipo // 1
            {
                Id = Guid.Parse("4c8de6be-914a-40e4-a671-4f00ea50417b"),
                Descritivo = "apartamento"
            },
            new Tipo // 2
            {
                Id = Guid.Parse("d060ba4f-44b9-44dc-8edf-5f3f2eb51475"),
                Descritivo = "casa"
            },
            new Tipo // 3
            {
                Id = Guid.Parse("c1e973af-fd45-4de9-a754-08b07c8cfa56"),
                Descritivo = "chacara"
            },
            new Tipo // 4
            {
                Id = Guid.Parse("be00769e-7481-4fcb-8c64-6378931cdda3"),
                Descritivo = "sala comercial"
            },
        });

        // Imoveis
        modelBuilder.Entity<Imovel>().HasData(new List<Imovel>
        {
            new Imovel // 1
            {
                Id = Guid.Parse("4232f2c4-a816-41f9-8a3b-8f0e1bef107b"),
                Descritivo = "duplex com 2 suites ****",
                Estado = "sp",
                Aluguel = 20000.00,
                TipoId = Guid.Parse("4c8de6be-914a-40e4-a671-4f00ea50417b"),
                ProprietarioId = Guid.Parse("65209a0d-2263-41a1-a277-e5abd00fa220"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 2
            {
                Id = Guid.Parse("dc3d5b85-0314-4477-82be-16cb10b40841"),
                Descritivo = "2 quartos com 1 suite",
                Estado = "RJ",
                Aluguel = 10000.00,
                TipoId = Guid.Parse("4c8de6be-914a-40e4-a671-4f00ea50417b"),
                ProprietarioId = Guid.Parse("951c32cf-f8a8-4048-addc-567e88a24d88"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 3
            {
                Id = Guid.Parse("a524a489-ac87-4e5a-9da3-43b0cd0564cf"),
                Descritivo = "4 quartos com 2 suites",
                Estado = "SP",
                Aluguel = 1640.25,
                TipoId = Guid.Parse("d060ba4f-44b9-44dc-8edf-5f3f2eb51475"),
                ProprietarioId = Guid.Parse("04c4e003-a194-4d96-ad3f-057c59fe34bc"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 4
            {
                Id = Guid.Parse("4848ac2c-07f9-41ae-ad5d-bdb2d4cda84b"),
                Descritivo = "casa terrea com 2 quartos",
                Estado = "SP",
                Aluguel = 951.35,
                TipoId = Guid.Parse("d060ba4f-44b9-44dc-8edf-5f3f2eb51475"),
                ProprietarioId = Guid.Parse("04c4e003-a194-4d96-ad3f-057c59fe34bc"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 5
            {
                Id = Guid.Parse("f451ee27-f5d6-4772-9479-e25fb6123d20"),
                Descritivo = "chacara com piscina e churrasqueira e 2 ",
                Estado = "SP",
                Aluguel = 1443.42,
                TipoId = Guid.Parse("c1e973af-fd45-4de9-a754-08b07c8cfa56"),
                ProprietarioId = Guid.Parse("53945e77-7c5e-46f3-827c-8174d4a26794"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 6
            {
                Id = Guid.Parse("864ab5f4-98eb-4afa-909c-51db0a987e9d"),
                Descritivo = "sobrado com 3 quartos",
                Estado = "RJ",
                Aluguel = 2500.00,
                TipoId = Guid.Parse("d060ba4f-44b9-44dc-8edf-5f3f2eb51475"),
                ProprietarioId = Guid.Parse("38463aaa-e9d0-44ac-b7aa-0399465103a7"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 7
            {
                Id = Guid.Parse("0252c521-40db-4d8b-8837-47dccc30fe25"),
                Descritivo = "loja terrea com banheiro",
                Estado = "SP",
                Aluguel = 590.49,
                TipoId = Guid.Parse("be00769e-7481-4fcb-8c64-6378931cdda3"),
                ProprietarioId = Guid.Parse("951c32cf-f8a8-4048-addc-567e88a24d88"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 8
            {
                Id = Guid.Parse("52bb3784-9b70-46eb-8ebb-797affbf61b1"),
                Descritivo = "kitnet com sala xbdfnbbbb",
                Estado = "SP",
                Aluguel = 501.92,
                TipoId = Guid.Parse("4c8de6be-914a-40e4-a671-4f00ea50417b"),
                ProprietarioId = Guid.Parse("04c4e003-a194-4d96-ad3f-057c59fe34bc"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
            new Imovel // 9
            {
                Id = Guid.Parse("6bfe7fe0-488b-4e66-b192-b35a67b102cb"),
                Descritivo = "casa na praia com 2 quartos",
                Estado = "SP",
                Aluguel = 656.10,
                TipoId = Guid.Parse("d060ba4f-44b9-44dc-8edf-5f3f2eb51475"),
                ProprietarioId = Guid.Parse("04c4e003-a194-4d96-ad3f-057c59fe34bc"),
                DataCadastro = DateTime.Now.AddYears(-2)
            },
        });

        // Locacao
        modelBuilder.Entity<Locacao>().HasData(new List<Locacao>
        {
            new Locacao // 1
            {
                Id = Guid.Parse("7483b16b-df4e-4154-9113-5bf72c7693ed"),
                InquilinoId = Guid.Parse("a5533bd8-f1a6-42a5-839f-63f6b55f47f8"),
                ImovelId = Guid.Parse("dc3d5b85-0314-4477-82be-16cb10b40841"),
                DataLocacao = DateTime.Now
            },
            new Locacao // 2
            {
                Id = Guid.Parse("a3d3937b-e4c5-4737-91df-1ef8b8a2a24b"),
                InquilinoId = Guid.Parse("4a6fe6d2-693a-4e4b-8bbf-b6a9169ec169"),
                ImovelId = Guid.Parse("a524a489-ac87-4e5a-9da3-43b0cd0564cf"),
                DataLocacao = DateTime.Now
            },
            new Locacao // 3
            {
                Id = Guid.Parse("a60c5d9f-3da0-4b27-b0ab-03bdb0ede62b"),
                InquilinoId = Guid.Parse("97d2dd37-fbaf-4d8e-b618-003e20dbdbb7"),
                ImovelId = Guid.Parse("4848ac2c-07f9-41ae-ad5d-bdb2d4cda84b"),
                DataLocacao = DateTime.Now
            },
            new Locacao // 4
            {
                Id = Guid.Parse("f5065e20-be18-41fc-843c-7446b9383545"),
                InquilinoId = Guid.Parse("5f2c27f5-d24e-41c2-8322-50ed3bb0d5d2"),
                ImovelId = Guid.Parse("0252c521-40db-4d8b-8837-47dccc30fe25"),
                DataLocacao = DateTime.Now
            },
            new Locacao // 5
            {
                Id = Guid.Parse("ba164ecc-35d3-456a-adc3-59801d02f3da"),
                InquilinoId = Guid.Parse("f5ffaafc-beae-4b0f-a53c-b0947348fb88"),
                ImovelId = Guid.Parse("f451ee27-f5d6-4772-9479-e25fb6123d20"),
                DataLocacao = DateTime.Now
            },
            new Locacao // 6
            {
                Id = Guid.Parse("3f64b8b8-7adb-48a0-9f14-e675fc8986a0"),
                InquilinoId = Guid.Parse("1bbf3fb8-f669-47d7-a390-967034f34c26"),
                ImovelId = Guid.Parse("52bb3784-9b70-46eb-8ebb-797affbf61b1"),
                DataLocacao = DateTime.Now
            },
        });
    }
}