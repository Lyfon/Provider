using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LyfOnLibrary.Service;
using LyfOnLibrary.Model;

namespace LyfOn.Controllers
{
    public class ProviderController : Controller
    {

        private ReadService ReadService { get; }

        private WriteService WriteService { get; }

        private LoginView Provider { get; set; }

        public ProviderController()
        {
            ReadService = new ReadService(System.Configuration.ConfigurationManager.ConnectionStrings["LyfOn"].ConnectionString);
            WriteService = new WriteService(System.Configuration.ConfigurationManager.ConnectionStrings["LyfOn"].ConnectionString);           
        }
        // GET: Provider
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Discover()
        {
            try
            {
                //return View(SampleService1.GetAllDiscover());
                return View();
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Publisher()
        {
            try
            {                
                Criteria.PublisherCriteria criteria = new Criteria.PublisherCriteria();
                return View(ReadService.GetPublisherByCriteria(criteria));
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Submissions(int page = 1, string sort = "UserName", string sortdir = "asc", string search = "")
        {

            try
            {
                //int pageSize = 5;
                //int totRecord = 0;
                //if (page < 1) page = 1;
                //int skip = (page * pageSize) - pageSize;
                //var data = SampleService.GetSubmission(search, sort, sortdir, skip, pageSize, out totRecord);
                //ViewBag.Totalrecords = totRecord;
                //var data1 = data.AsEnumerable().ToList();
                Provider = (LoginView)Session["User"];
                Criteria.SubmissionCriteria criteria = new Criteria.SubmissionCriteria();
                criteria.ProviderId = Provider.UserId;
                var result = ReadService.GetSubmissionByCriteria(criteria);
                ViewBag.Totalrecords = result.Count();
                return View(result);
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Inprogress()
        {
            try
            {
                Provider = (LoginView)Session["User"];
                Criteria.SubmissionCriteria criteria = new Criteria.SubmissionCriteria();
                criteria.ProviderId = Provider.UserId;
                criteria.StatusId = 3;
                var result = ReadService.GetSubmissionByCriteria(criteria);
                ViewBag.Totalrecords = result.Count();
                return View(result);
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Accepted()
        {
            try
            {
                Provider = (LoginView)Session["User"];
                Criteria.SubmissionCriteria criteria = new Criteria.SubmissionCriteria();
                criteria.ProviderId = Provider.UserId;
                criteria.StatusId = 1;
                var result = ReadService.GetSubmissionByCriteria(criteria);
                ViewBag.Totalrecords = result.Count();
                return View(result);

            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Declined()
        {
            try
            {
                Provider = (LoginView)Session["User"];
                Criteria.SubmissionCriteria criteria = new Criteria.SubmissionCriteria();
                criteria.ProviderId = Provider.UserId;
                criteria.StatusId = 2;
                var result = ReadService.GetSubmissionByCriteria(criteria);
                ViewBag.Totalrecords = result.Count();
                return View(result);

            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Withdrawn()
        {
            try
            {
                Provider = (LoginView)Session["User"];
                Criteria.SubmissionCriteria criteria = new Criteria.SubmissionCriteria();
                criteria.ProviderId = Provider.UserId;
                criteria.StatusId = 5;
                var result = ReadService.GetSubmissionByCriteria(criteria);
                ViewBag.Totalrecords = result.Count();
                return View(result);
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult SavedDraft()
        {
            try
            {
                //int pageSize = 5;
                //int totRecord = 0;
                //if (page < 1) page = 1;
                //int skip = (page * pageSize) - pageSize;
                //var data = SampleService1.GetSavedDraft(search, sort, sortdir, skip, pageSize, out totRecord);
                //ViewBag.Totalrecords = totRecord;
                //var data1 = data.AsEnumerable().ToList();
                //return View(data1);
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Following()
        {
            try
            {
                Provider = (LoginView)Session["User"];
                var result = ReadService.GeFollowingById(Provider.UserId);

                return View(result);
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult NotReviewed()
        {
            try
            {
                Provider = (LoginView)Session["User"];
                Criteria.SubmissionCriteria criteria = new Criteria.SubmissionCriteria();
                criteria.ProviderId = Provider.UserId;
                criteria.StatusId = 4;
                var result = ReadService.GetSubmissionByCriteria(criteria);
                ViewBag.Totalrecords = result.Count();
                return View(result);
            }
            catch (Exception) { }
            return View();
        }

        public ActionResult Withdraw()
        {

            try { } catch (Exception) { }
            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {

            try { } catch (Exception) { }
            return RedirectToAction("Index");
        }

        public ActionResult Remove()
        {

            try { } catch (Exception) { }
            return RedirectToAction("Index");
        }

        public ActionResult DiscoverDetail()
        {

            try
            {
                //return View(SampleService1.GetDiscoverDetail());
            }
            catch (Exception) { }
            return View();
        }

    }
}
