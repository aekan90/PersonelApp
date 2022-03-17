

using System.Collections.Generic;

namespace PersonelApp.Domains
{
    public class Department : BaseEntity
    {
        // Personnels ICollection yapısında olduğu için
        // NullReferance hatası almamak için 
        // Personnels listesini hafızaya çıkartmam gerekiyor
        public Department()
        {
            Personnels = new List<Personnel>(); 
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personnel> Personnels { get; set; }

    }
}

