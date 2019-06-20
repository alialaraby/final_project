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
  public   class InstructorBll
    {
      
        public static List<instructorQualificationPhoneViewModel> getAllIstructors()
        {
            MCenterDBContext db = new MCenterDBContext();
            
            List<instructorQualificationPhoneViewModel> lstInstructors = db.instructors.Select(x => 
            new instructorQualificationPhoneViewModel { instructor_name = x.instructor_name,
                                                        Current_JobTitle = x.Current_JobTitle,
                                                        TrainningTopic = x.TrainningTopic,
                                                         NameOf_ItsUnit=x.NameOf_ItsUnit,instructor_id=x.instructor_id }).ToList();
            return lstInstructors;

        }

        public static void AddInstructor(instructorQualificationPhoneViewModel instructorvm)
        {
            MCenterDBContext db = new MCenterDBContext();
            instructor newInstructor = new instructor();
            newInstructor.instructor_name = instructorvm.instructor_name;
            newInstructor.NameOf_ItsUnit = instructorvm.NameOf_ItsUnit;
            newInstructor.TrainningTopic = instructorvm.TrainningTopic;
            newInstructor.Current_JobTitle = instructorvm.Current_JobTitle;
            db.instructors.Add(newInstructor);
            db.SaveChanges();

             instructor_phone newPhone = new instructor_phone();
            newPhone.phone = instructorvm.phone;
            newPhone.instructor_id = newInstructor.instructor_id;
            db.instructor_phone.Add(newPhone);
            db.SaveChanges();


        }

        public static void UpdateInstructor(instructorQualificationPhoneViewModel instructorvm)
        {
            MCenterDBContext db = new MCenterDBContext();
            instructor updataedInstructor= getInstructorByID(instructorvm.instructor_id);
            updataedInstructor.instructor_name = instructorvm.instructor_name;
            updataedInstructor.NameOf_ItsUnit = instructorvm.NameOf_ItsUnit;
            updataedInstructor.TrainningTopic = instructorvm.TrainningTopic;
            db.SaveChanges();
        }

        public static void DeleteInstructor(int id)
        {
            MCenterDBContext db = new MCenterDBContext();
            instructor deletedIns = getInstructorByID(id);

            //delete from qualification instructor
            //delete from phone instructor

            DeletePhoneInstructor(id);
        }
        public static void DeletePhoneInstructor(int insid)
        {
            MCenterDBContext db = new MCenterDBContext();
            List<instructor_phone> instructor_Phones = db.instructor_phone.Where(x => x.instructor_id == insid).ToList();
            foreach (var item in instructor_Phones)
            {
                db.instructor_phone.Remove(item);
                db.SaveChanges();
            }
        }
        public static instructor getInstructorByID(int id)
        {
            MCenterDBContext db = new MCenterDBContext();


       //     instructorQualificationPhoneViewModel instructor = db.instructors.Where(x => x.instructor_id == id).Select(x =>
       //new instructorQualificationPhoneViewModel
       //{
       //    instructor_name = x.instructor_name,
       //    Current_JobTitle = x.Current_JobTitle,
       //    TrainningTopic = x.TrainningTopic,
       //    NameOf_ItsUnit = x.NameOf_ItsUnit,
       //    instructor_id = x.instructor_id
       //}).SingleOrDefault();
            instructor instructor = db.instructors.Where(x => x.instructor_id == id).SingleOrDefault();
            return instructor;
        }
    }
}
