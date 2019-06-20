using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL.ViewModels
{
    public class labVM
    {
        public int lab_id { get; set; }

        public int service_id { get; set; }

        public int? lab_number { get; set; }

        public string lab_name { get; set; }

        public int? floor_number { get; set; }

        public string description { get; set; }

    }
}
