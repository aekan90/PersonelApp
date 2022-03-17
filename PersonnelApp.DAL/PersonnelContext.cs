

using PersonelApp.Domains;
using System.Data.Entity;

namespace PersonnelApp.DAL
{
    public class PersonnelContext :DbContext
    {
        public PersonnelContext():base("PersonnelContext")
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
    }
}
