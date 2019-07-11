using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BitirmeProjesi_TUGCETUGSAL
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
        {
            //Database.Connection.ConnectionString = @"server=TUĞÇE\MYSQL;database= BitirmeProjesi;uid=sa;pwd=12345";
            //Database.SetInitializer<ProjeContext>(new CreateDatabaseIfNotExists<ProjeContext>());

            Database.Connection.ConnectionString = @"server=DESKTOP-KHOPMPR\SQLSERVER;database= BitirmeProjesi;uid=sa;pwd=12345";
            Database.SetInitializer<ProjeContext>(new CreateDatabaseIfNotExists<ProjeContext>());

        }

        public DbSet<Employee> Employees { get; set; }//Databasede employees adında employee sınıfdaki propları kullanarak table oluşturuyor
        public DbSet<Department> Departments { get; set; }

    

    }
}
