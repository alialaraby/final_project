using FinalProject.BLL.ViewModels;
using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL.BusinessLayer
{
  public class labBLL
    {
        MCenterDBContext db = new MCenterDBContext();
        public List<labVM> getAllLabs()
        {
            List<labVM> mylabs = new List<labVM>();
            var lab = db.labs.ToList();

            foreach (var item in lab)
            {
                labVM lbobj = new labVM();
                lbobj.lab_id = item.lab_id;
                lbobj.lab_name = item.lab_name;
                lbobj.lab_number = item.lab_number;
                lbobj.description = item.description;
                lbobj.floor_number = item.floor_number;
                lbobj.service_id = item.service_id;




               mylabs.Add(lbobj);
            }

            return mylabs;
        }
    }
}
