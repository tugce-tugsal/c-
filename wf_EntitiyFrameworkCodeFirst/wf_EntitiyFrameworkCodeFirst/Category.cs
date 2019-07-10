using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_EntitiyFrameworkCodeFirst
{
    //Varsayım olarak önce sözleşmeler devreye girer,sonra dataAnotations lar en son olarak bunlarla yapamdıklarımız için fluent API lar kullanılır.
    public class Category
    {
        //Sözleşme defoult olarak int tipindeki ismi ıd yada classId olan kolonlaı primary key olarak kabul eder.
        [Key] 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
