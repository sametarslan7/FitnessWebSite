using FitnessWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessWebSite.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //PRIVATE PROGRAM

        public ActionResult PrivateProgramList()
        {
            var deger = c.Programs.ToList();
            return View(deger);
        }
        public ActionResult GetPrivateProgram(int id)
        {
            var getprivateprogram = c.Programs.Find(id);
            return View("GetPrivateProgram", getprivateprogram);
        }
        public ActionResult UpdatePrivateProgram(PrivateProgram x)
        {
            var pr = c.Programs.Find(x.id);
            pr.programName = x.programName;
            pr.programDetail = x.programDetail;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        //FREE PROGRAM

        public ActionResult FreeProgramList()
        {
            var deger = c.FreePrograms.ToList();
            return View(deger);
        }
        public ActionResult GetFreeProgram(int id)
        {
            var getfreeprogram=c.FreePrograms.Find(id);
            return View("GetFreeProgram", getfreeprogram);
        }
        public ActionResult UpdateFreeProgram(FreeProgram f)
        {
            var fr = c.FreePrograms.Find(f.id);
            fr.freeProgramName = f.freeProgramName;
            fr.freeProgramDetail = f.freeProgramDetail;
            fr.freeProgramFilePath = f.freeProgramFilePath;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        //GROUP LESSONS

        public ActionResult GroupLessonsList()
        {
            var deger=c.GroupClasses.ToList();
            return View(deger);
        }
        public ActionResult GetGroupLesson(int id)
        {
            var getgrouplesson=c.GroupClasses.Find(id);
            return View("GetGroupLesson",getgrouplesson);
        }
        public ActionResult UpdateGroupLesson(GroupClass g)
        {
            var gr = c.GroupClasses.Find(g.id);
            gr.className = g.className;
            gr.classDetail = g.classDetail;
            gr.classFilePath = g.classFilePath;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        //TRAINERS

        public ActionResult TrainerList()
        {
            var deger = c.Trainers.ToList();
            return View(deger);
        }
        public ActionResult GetTrainer(int id)
        {
            var gettrainer=c.Trainers.Find(id);
            return View("GetTrainer",gettrainer);
        }
        public ActionResult UpdateTrainer(Trainer t)
        {
            var tr = c.Trainers.Find(t.id);
            tr.trainerName = t.trainerName;
            tr.trainerMajor = t.trainerMajor;
            tr.trainerDescription = t.trainerDescription;
            tr.trainerProfilePhoto = t.trainerProfilePhoto;
            tr.trainerExperience = t.trainerExperience;
            tr.trainerActiveMember = t.trainerActiveMember;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}