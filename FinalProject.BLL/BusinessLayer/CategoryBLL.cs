using FinalProject.BLL.ViewModels;
using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL.BusinessLayer
{
    public class CategoryBLL
    {
        MCenterDBContext mcdb = new MCenterDBContext();
        public List<CategoryVM> getAllCategs()
        {
            List<CategoryVM> categs = new List<CategoryVM>();
            var categ = mcdb.courses_category.ToList();

            foreach (var item in categ)
            {
                CategoryVM cmv = new CategoryVM();
                cmv.category_id = item.category_id;
                cmv.category_name = item.category_name;
                categs.Add(cmv);
            }

            return categs;
        }
    }
}
