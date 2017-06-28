using AceleraToDoList.Data.Mapping;
using AceleraToDoList.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AceleraToDoList.Data.Contexts
{
    public class PratokeDbContect : DbContext
    {
        public PratokeDbContect()
            : base("PratokeDbConection")
        {
            Database.SetInitializer<PratokeDbContect>(null);
            Database.CommandTimeout = 60;
        }

        public DbSet<tbUsuariosEntity> TbUsuariosEntity { get; set; }
        public DbSet<tbControleDeCadastroEntity> tbControleDeCadastroEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Configurations.Add(new tbUsuariosMap());
            modelBuilder.Configurations.Add(new tbControleDeCadastroMap());

        }
    }
}



