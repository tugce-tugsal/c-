using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BitirmeProjesi_TUGCETUGSAL
{
   public class Department
    {
        [Key]
        public int DepartmanID { get; set; }
        
        private string _departman;

        public string Departman
        {
            get { return _departman; }
            set { _departman = value.ToUpper(); }
        }

        public string Aciklama { get; set; }
    }
        
   }

