using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_EntitiyFrameworkCodeFirst
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        
        public decimal? UnitPrice { get; set; }//soru işareti null değer olabilir yaptık.Bütün nümerikler için geçerlidir soru işareti.
        public short UnitInstock { get; set; }
        //[ForeignKey("Category")] Bunu yazmasakda anlıcak key koycak
        //public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        
    }
}
