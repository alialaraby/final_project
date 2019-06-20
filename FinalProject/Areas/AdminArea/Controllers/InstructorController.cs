using FinalProject.BLL.BusinessLayers;
using FinalProject.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FinalProject.DAL;
 
namespace FinalProject.Areas.AdminArea.Controllers
{
    public class InstructorController : Controller
    {
        // GET: AdminArea/Instructor
        // GET: Employee
        public ActionResult index()
        {
            
            ViewBag.Istructors = InstructorBll.getAllIstructors();
            
            ViewBag.Qualifications = QualificationBll.getQualifications();

            return View();
        }
        public ActionResult AddInstructor()
        {
            ViewBag.Qualifications = QualificationBll.getQualifications();

            return View();
        }
        [HttpPost]
        public ActionResult AddInstructor(instructorQualificationPhoneViewModel instructorvm)
        {
           InstructorBll.AddInstructor(instructorvm);
            ViewBag.Istructors = InstructorBll.getAllIstructors();

            ViewBag.Qualifications = QualificationBll.getQualifications();

            return RedirectToAction("index");
        }
        public ActionResult Edit(int id)
        {
            instructor instructor = InstructorBll.getInstructorByID(id);

            instructorQualificationPhoneViewModel insvm = new instructorQualificationPhoneViewModel();
            insvm.instructor_id = instructor.instructor_id;
            insvm.instructor_name = instructor.instructor_name;
            insvm.NameOf_ItsUnit = instructor.NameOf_ItsUnit;
            insvm.TrainningTopic = instructor.TrainningTopic;


                
         return View(insvm);
        }
        [HttpPost]
        public ActionResult Edit(instructorQualificationPhoneViewModel instructorvm)
        {
            InstructorBll.UpdateInstructor(instructorvm);
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult delete(int id)
        {
            InstructorBll.DeleteInstructor(id);

            ViewBag.Istructors = InstructorBll.getAllIstructors();

            ViewBag.Qualifications = QualificationBll.getQualifications();

            return RedirectToAction("index");
        }

    }
}