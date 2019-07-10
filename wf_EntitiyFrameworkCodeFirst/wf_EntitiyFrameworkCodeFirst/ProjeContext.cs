using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_EntitiyFrameworkCodeFirst
{
    public class ProjeContext:DbContext
    {
        public ProjeContext():base("NorthWindERP2DbCon")
        {
            //intstall dan entity indirdik (manage nuget packets) DbContext using yap. 
            //Database.Connection.ConnectionString = @"server=DESKTOP-KHOPMPR\SQLSERVER;database= NorthWindShoup2Db;uid=sa;pwd=12345";
           
            // Database.SetInitializer<ProjeContext>(new CreateDatabaseIfNotExists<ProjeContext>());//Hiç birşey demezsem çalışan strateji budur.

            //base ile yapımı:
            
            Database.SetInitializer<ProjeContext>(new DropCreateDatabaseIfModelChanges<ProjeContext>());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
    
}
