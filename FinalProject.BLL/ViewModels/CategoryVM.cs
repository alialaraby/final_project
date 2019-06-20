using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL.ViewModels
{
    public class CategoryVM
    {
        public int category_id { get; set; }

        [StringLength(50)]
        public string category_name { get; set; }
    }
}
