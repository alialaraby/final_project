using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.BLL;
using FinalProject.BLL.ViewModels;
using FinalProject.DAL;
namespace FinalProject.BLL.BusinessLayers
{
   public class QualificationBll
    {
       
        public static List<qualification> getQualifications()
        {
            MCenterDBContext db = new MCenterDBContext();
            List<qualification> qualifications = db.qualifications.ToList();
            return qualifications;
        }
        //public static bool DeleteQualificationsForInstructor(int insid)
        //{
        //    MenofiaCenterDB db = new MenofiaCenterDB();
        //    List<qualification> qualifications = db.i.Where(x=>x.instruct);
        //    return qualifications;
        //}
    }
}
