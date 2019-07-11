using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BitirmeProjesi_TUGCETUGSAL
{
   public class Employee
    {
        [Key]
        public int PersonelID { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }
        
        //[MaxLength(11), MinLength(11),Required, Index(IsUnique = true)]
        [MaxLength(11), MinLength(11), Required]
        public string TC { get; set; }
       
        public int Yas { get; set; }
       
        
        
        public string Mezuniyet { get; set; }

        [MaxLength(11), MinLength(11)]
        public string Telefon { get; set; }
       
        
        
        public int DepartmanID { get; set; }
        [Required]
        public string Cinsiyet { get; set; }
        public List<Department> Departments { get; set; }
    }
}
