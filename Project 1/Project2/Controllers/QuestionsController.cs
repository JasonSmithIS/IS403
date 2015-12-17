using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project2.DAL;
using Project2.Models;

namespace Project2.Controllers
{
    public class QuestionsController : Controller
    {
        private MissionContext db = new MissionContext();

        // GET: Questions
        [Authorize]
        public ActionResult Index(int? id)
        {
            Missions missions = db.Missions.Find(id);
            ViewBag.mission = missions;
            return View(db.Questions.ToList());
        }

        // GET: Questions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = db.Questions.Find(id);
            Missions missions = db.Missions.Find(questions.MissionId);
            ViewBag.mission = missions;
            if (questions == null)
            {
                return HttpNotFound();
            }
            return View(questions);
        }

        // GET: Questions/Create
        public ActionResult Create(int MissionId)
        {
            Missions missions = db.Missions.Find(MissionId);
            ViewBag.mission = missions;
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestionId,Question,Answer,MissionId,UserId")] Questions questions, int? mid)
        {
            if (ModelState.IsValid)
            {
                var email = User.Identity.Name;
                string userid = db.Users.Where(u => u.UserId == email).First().UserId;
                questions.UserId = userid;

                //int missionid = db.Missions.Where(u => u.MissionId == mid).First().MissionId;
                mid = questions.MissionId;

                db.Questions.Add(questions);
                db.SaveChanges();
                return RedirectToAction("Index", new{ id = mid});
            }

            return View(questions);
        }

        // GET: Questions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = db.Questions.Find(id);
            if (questions == null)
            {
                return HttpNotFound();
            }
            return View(questions);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuestionId,Question,Answer,MissionId,UserId")] Questions questions)
        {
            if (ModelState.IsValid)
            {
                var email = User.Identity.Name;
                string userid = db.Users.Where(u => u.UserId == email).First().UserId;
                questions.UserId = userid;

                //int missionid = db.Missions.Where(u => u.MissionId == mid).First().MissionId;
                int mid = questions.MissionId;

                db.Entry(questions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = mid });
            }
            return View(questions);
        }
        ////Pasted from Parker
        //// POST: DegreeQuestions/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "DegreeQID,DegreeID,IndividualID,Question,Answer")] DegreeQuestion degreeQuestion, int? did)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var email = User.Identity.Name;
        //        int individualID = db.Individuals.Where(u => u.IndividualEmail == email).First().IndividualID;
        //        degreeQuestion.IndividualID = individualID;

        //        int degreeID = db.Degrees.Where(u => u.DegreeID == did).First().DegreeID;
        //        degreeQuestion.DegreeID = degreeID;

        //        db.Entry(degreeQuestion).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(degreeQuestion);
        //}
        //end pasted from Parker
        // GET: Questions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questions questions = db.Questions.Find(id);
            if (questions == null)
            {
                return HttpNotFound();
            }
            return View(questions);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Questions questions = db.Questions.Find(id);
            int mid = questions.MissionId;
            db.Questions.Remove(questions);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = mid });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
