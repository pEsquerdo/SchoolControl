using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolControl.Model;


namespace SchoolControl.Dao
{
    public class DataContext : DbContext
    {
        //Crio um construtor para o DataContext que passa a ConnectionString para a classe mãe(DbContext)
        public DataContext() : base(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        // Definir os DbSet's para cada uma das Models
        // Serão criadas Tabelas no Banco para os DbSets/Models

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
