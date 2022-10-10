using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace @base.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inquilinos",
                columns: new[] { "Id", "Nome", "Sexo" },
                values: new object[,]
                {
                    { new Guid("1bbf3fb8-f669-47d7-a390-967034f34c26"), "Antonio", "M" },
                    { new Guid("4a6fe6d2-693a-4e4b-8bbf-b6a9169ec169"), "João", "M" },
                    { new Guid("5f2c27f5-d24e-41c2-8322-50ed3bb0d5d2"), "Rute", "F" },
                    { new Guid("97d2dd37-fbaf-4d8e-b618-003e20dbdbb7"), "Maria", "F" },
                    { new Guid("a5533bd8-f1a6-42a5-839f-63f6b55f47f8"), "Jose", "M" },
                    { new Guid("f5ffaafc-beae-4b0f-a53c-b0947348fb88"), "Manoel", "M" }
                });

            migrationBuilder.InsertData(
                table: "Proprietarios",
                columns: new[] { "Id", "Nascimento", "Nome", "Sexo" },
                values: new object[,]
                {
                    { new Guid("04c4e003-a194-4d96-ad3f-057c59fe34bc"), new DateTime(2002, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8844), "lucas", "M" },
                    { new Guid("38463aaa-e9d0-44ac-b7aa-0399465103a7"), new DateTime(2002, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8850), "gabriel", "M" },
                    { new Guid("53945e77-7c5e-46f3-827c-8174d4a26794"), new DateTime(2002, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8847), "patricia", "F" },
                    { new Guid("65209a0d-2263-41a1-a277-e5abd00fa220"), new DateTime(2002, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8824), "wdson", "M" },
                    { new Guid("951c32cf-f8a8-4048-addc-567e88a24d88"), new DateTime(2002, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8852), "cação", "M" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "Id", "Descritivo" },
                values: new object[,]
                {
                    { new Guid("4c8de6be-914a-40e4-a671-4f00ea50417b"), "apartamento" },
                    { new Guid("be00769e-7481-4fcb-8c64-6378931cdda3"), "sala comercial" },
                    { new Guid("c1e973af-fd45-4de9-a754-08b07c8cfa56"), "chacara" },
                    { new Guid("d060ba4f-44b9-44dc-8edf-5f3f2eb51475"), "casa" }
                });

            migrationBuilder.InsertData(
                table: "Imoveis",
                columns: new[] { "Id", "Aluguel", "DataCadastro", "Descritivo", "Estado", "ProprietarioId", "TipoId" },
                values: new object[,]
                {
                    { new Guid("0252c521-40db-4d8b-8837-47dccc30fe25"), 590.49000000000001, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8973), "loja terrea com banheiro", "SP", new Guid("951c32cf-f8a8-4048-addc-567e88a24d88"), new Guid("be00769e-7481-4fcb-8c64-6378931cdda3") },
                    { new Guid("4232f2c4-a816-41f9-8a3b-8f0e1bef107b"), 20000.0, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8941), "duplex com 2 suites ****", "sp", new Guid("65209a0d-2263-41a1-a277-e5abd00fa220"), new Guid("4c8de6be-914a-40e4-a671-4f00ea50417b") },
                    { new Guid("4848ac2c-07f9-41ae-ad5d-bdb2d4cda84b"), 951.35000000000002, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8958), "casa terrea com 2 quartos", "SP", new Guid("04c4e003-a194-4d96-ad3f-057c59fe34bc"), new Guid("d060ba4f-44b9-44dc-8edf-5f3f2eb51475") },
                    { new Guid("52bb3784-9b70-46eb-8ebb-797affbf61b1"), 501.92000000000002, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8978), "kitnet com sala xbdfnbbbb", "SP", new Guid("04c4e003-a194-4d96-ad3f-057c59fe34bc"), new Guid("4c8de6be-914a-40e4-a671-4f00ea50417b") },
                    { new Guid("6bfe7fe0-488b-4e66-b192-b35a67b102cb"), 656.10000000000002, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8982), "casa na praia com 2 quartos", "SP", new Guid("04c4e003-a194-4d96-ad3f-057c59fe34bc"), new Guid("d060ba4f-44b9-44dc-8edf-5f3f2eb51475") },
                    { new Guid("864ab5f4-98eb-4afa-909c-51db0a987e9d"), 2500.0, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8969), "sobrado com 3 quartos", "RJ", new Guid("38463aaa-e9d0-44ac-b7aa-0399465103a7"), new Guid("d060ba4f-44b9-44dc-8edf-5f3f2eb51475") },
                    { new Guid("a524a489-ac87-4e5a-9da3-43b0cd0564cf"), 1640.25, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8953), "4 quartos com 2 suites", "SP", new Guid("04c4e003-a194-4d96-ad3f-057c59fe34bc"), new Guid("d060ba4f-44b9-44dc-8edf-5f3f2eb51475") },
                    { new Guid("dc3d5b85-0314-4477-82be-16cb10b40841"), 10000.0, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8949), "2 quartos com 1 suite", "RJ", new Guid("951c32cf-f8a8-4048-addc-567e88a24d88"), new Guid("4c8de6be-914a-40e4-a671-4f00ea50417b") },
                    { new Guid("f451ee27-f5d6-4772-9479-e25fb6123d20"), 1443.4200000000001, new DateTime(2020, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(8963), "chacara com piscina e churrasqueira e 2 ", "SP", new Guid("53945e77-7c5e-46f3-827c-8174d4a26794"), new Guid("c1e973af-fd45-4de9-a754-08b07c8cfa56") }
                });

            migrationBuilder.InsertData(
                table: "Locacao",
                columns: new[] { "Id", "DataLocacao", "ImovelId", "InquilinoId" },
                values: new object[,]
                {
                    { new Guid("3f64b8b8-7adb-48a0-9f14-e675fc8986a0"), new DateTime(2022, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(9054), new Guid("52bb3784-9b70-46eb-8ebb-797affbf61b1"), new Guid("1bbf3fb8-f669-47d7-a390-967034f34c26") },
                    { new Guid("7483b16b-df4e-4154-9113-5bf72c7693ed"), new DateTime(2022, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(9030), new Guid("dc3d5b85-0314-4477-82be-16cb10b40841"), new Guid("a5533bd8-f1a6-42a5-839f-63f6b55f47f8") },
                    { new Guid("a3d3937b-e4c5-4737-91df-1ef8b8a2a24b"), new DateTime(2022, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(9037), new Guid("a524a489-ac87-4e5a-9da3-43b0cd0564cf"), new Guid("4a6fe6d2-693a-4e4b-8bbf-b6a9169ec169") },
                    { new Guid("a60c5d9f-3da0-4b27-b0ab-03bdb0ede62b"), new DateTime(2022, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(9041), new Guid("4848ac2c-07f9-41ae-ad5d-bdb2d4cda84b"), new Guid("97d2dd37-fbaf-4d8e-b618-003e20dbdbb7") },
                    { new Guid("ba164ecc-35d3-456a-adc3-59801d02f3da"), new DateTime(2022, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(9048), new Guid("f451ee27-f5d6-4772-9479-e25fb6123d20"), new Guid("f5ffaafc-beae-4b0f-a53c-b0947348fb88") },
                    { new Guid("f5065e20-be18-41fc-843c-7446b9383545"), new DateTime(2022, 10, 5, 14, 57, 41, 314, DateTimeKind.Local).AddTicks(9044), new Guid("0252c521-40db-4d8b-8837-47dccc30fe25"), new Guid("5f2c27f5-d24e-41c2-8322-50ed3bb0d5d2") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("4232f2c4-a816-41f9-8a3b-8f0e1bef107b"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("6bfe7fe0-488b-4e66-b192-b35a67b102cb"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("864ab5f4-98eb-4afa-909c-51db0a987e9d"));

            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: new Guid("3f64b8b8-7adb-48a0-9f14-e675fc8986a0"));

            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: new Guid("7483b16b-df4e-4154-9113-5bf72c7693ed"));

            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: new Guid("a3d3937b-e4c5-4737-91df-1ef8b8a2a24b"));

            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: new Guid("a60c5d9f-3da0-4b27-b0ab-03bdb0ede62b"));

            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: new Guid("ba164ecc-35d3-456a-adc3-59801d02f3da"));

            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: new Guid("f5065e20-be18-41fc-843c-7446b9383545"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("0252c521-40db-4d8b-8837-47dccc30fe25"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("4848ac2c-07f9-41ae-ad5d-bdb2d4cda84b"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("52bb3784-9b70-46eb-8ebb-797affbf61b1"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("a524a489-ac87-4e5a-9da3-43b0cd0564cf"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("dc3d5b85-0314-4477-82be-16cb10b40841"));

            migrationBuilder.DeleteData(
                table: "Imoveis",
                keyColumn: "Id",
                keyValue: new Guid("f451ee27-f5d6-4772-9479-e25fb6123d20"));

            migrationBuilder.DeleteData(
                table: "Inquilinos",
                keyColumn: "Id",
                keyValue: new Guid("1bbf3fb8-f669-47d7-a390-967034f34c26"));

            migrationBuilder.DeleteData(
                table: "Inquilinos",
                keyColumn: "Id",
                keyValue: new Guid("4a6fe6d2-693a-4e4b-8bbf-b6a9169ec169"));

            migrationBuilder.DeleteData(
                table: "Inquilinos",
                keyColumn: "Id",
                keyValue: new Guid("5f2c27f5-d24e-41c2-8322-50ed3bb0d5d2"));

            migrationBuilder.DeleteData(
                table: "Inquilinos",
                keyColumn: "Id",
                keyValue: new Guid("97d2dd37-fbaf-4d8e-b618-003e20dbdbb7"));

            migrationBuilder.DeleteData(
                table: "Inquilinos",
                keyColumn: "Id",
                keyValue: new Guid("a5533bd8-f1a6-42a5-839f-63f6b55f47f8"));

            migrationBuilder.DeleteData(
                table: "Inquilinos",
                keyColumn: "Id",
                keyValue: new Guid("f5ffaafc-beae-4b0f-a53c-b0947348fb88"));

            migrationBuilder.DeleteData(
                table: "Proprietarios",
                keyColumn: "Id",
                keyValue: new Guid("38463aaa-e9d0-44ac-b7aa-0399465103a7"));

            migrationBuilder.DeleteData(
                table: "Proprietarios",
                keyColumn: "Id",
                keyValue: new Guid("65209a0d-2263-41a1-a277-e5abd00fa220"));

            migrationBuilder.DeleteData(
                table: "Proprietarios",
                keyColumn: "Id",
                keyValue: new Guid("04c4e003-a194-4d96-ad3f-057c59fe34bc"));

            migrationBuilder.DeleteData(
                table: "Proprietarios",
                keyColumn: "Id",
                keyValue: new Guid("53945e77-7c5e-46f3-827c-8174d4a26794"));

            migrationBuilder.DeleteData(
                table: "Proprietarios",
                keyColumn: "Id",
                keyValue: new Guid("951c32cf-f8a8-4048-addc-567e88a24d88"));

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: new Guid("4c8de6be-914a-40e4-a671-4f00ea50417b"));

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: new Guid("be00769e-7481-4fcb-8c64-6378931cdda3"));

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: new Guid("c1e973af-fd45-4de9-a754-08b07c8cfa56"));

            migrationBuilder.DeleteData(
                table: "Tipos",
                keyColumn: "Id",
                keyValue: new Guid("d060ba4f-44b9-44dc-8edf-5f3f2eb51475"));
        }
    }
}
