using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool_WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true),
                    sobrenome = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 1, "Madalena", "Puca", "46380112" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 8, "Melissa", "Zonodera", "46385252" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 7, "Emily", "Nascimento", "46365540" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 6, "Manuela", "Figueiredo", "46340278" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 9, "Isabela", "Zonodera", "46385252" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 4, "Stetifânia", "Zonodera", "46385252" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 3, "Helenice", "Dias", "46390022" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 2, "Cristiniane", "Queiroz", "46395581" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "id", "nome", "sobrenome", "telefone" },
                values: new object[] { 5, "Raphaela", "Honória", "46390114" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 8, "Lélia Zambrano" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 1, "Eduardo Lobo" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 2, "Almir Costa" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 3, "Cilene Araújo" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 4, "Ivaldo Franco" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 5, "Carlos Aragão" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 6, "Marcos Vasconcelos" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 7, "Edith Angulo" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "id", "nome" },
                values: new object[] { 9, "Geraldo Ribeiro" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 1, "IIN001 - Inteligência de Negócios", 1 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 2, "ISI951-Sistemas Integrados de Gestão e Aplicações", 2 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 3, "IGT002-Gestão de Tecnologia da Informação", 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 4, "IAL004-Algoritmos", 4 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 5, "IRC108-Redes de Computadores", 5 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 6, "GPJ002-Gestão de Projetos", 6 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 7, "IES951-Engenharia de Software e Aplicações", 7 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 8, "AGE001-Planejamento e Gestão Estratégica", 8 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[] { 9, "TAI001 - Tópicos Avançados em Tecnologia da Informação", 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 6 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 7 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 8 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 8, 9 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 9, 9 });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
