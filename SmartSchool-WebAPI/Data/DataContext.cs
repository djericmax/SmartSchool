using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1,"Eduardo Lobo"),
                    new Professor(2,"Almir Costa"),
                    new Professor(3,"Cilene Araújo"),
                    new Professor(4,"Ivaldo Franco"),
                    new Professor(5,"Carlos Aragão"),
                    new Professor(6,"Marcos Vasconcelos"),
                    new Professor(7,"Edith Angulo"),
                    new Professor(8,"Lélia Zambrano"),
                    new Professor(9,"Geraldo Ribeiro")
                });
            
            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina(1,"IIN001 - Inteligência de Negócios", 1),
                    new Disciplina(2,"ISI951-Sistemas Integrados de Gestão e Aplicações", 2),
                    new Disciplina(3,"IGT002-Gestão de Tecnologia da Informação", 3),
                    new Disciplina(4,"IAL004-Algoritmos", 4),
                    new Disciplina(5,"IRC108-Redes de Computadores", 5),
                    new Disciplina(6,"GPJ002-Gestão de Projetos", 6),
                    new Disciplina(7,"IES951-Engenharia de Software e Aplicações", 7),
                    new Disciplina(8,"AGE001-Planejamento e Gestão Estratégica", 8),
                    new Disciplina(9,"TAI001 - Tópicos Avançados em Tecnologia da Informação", 9)
                });
            
            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1,"Madalena", "Puca", "46380112"),
                    new Aluno(2,"Cristiniane", "Queiroz", "46395581"),
                    new Aluno(3,"Helenice", "Dias", "46390022"),
                    new Aluno(4,"Stetifânia", "Zonodera", "46385252"),
                    new Aluno(5,"Raphaela", "Honória", "46390114"),
                    new Aluno(6,"Manuela", "Figueiredo", "46340278"),
                    new Aluno(7,"Emily", "Nascimento", "46365540"),
                    new Aluno(8,"Melissa", "Zonodera", "46385252"),
                    new Aluno(9,"Isabela", "Zonodera", "46385252")
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 8, DisciplinaId = 9 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 6 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 7 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 8 },
                    new AlunoDisciplina() {AlunoId = 9, DisciplinaId = 9 }                    
                });
        }        
    }
}