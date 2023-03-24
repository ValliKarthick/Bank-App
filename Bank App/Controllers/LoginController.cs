using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank_App.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login()
        {
            if (ModelState.IsValid)
            {
                var loginValue = movieContext.loginCredentials.Where(a => a.UserId.Equals(loginCredential.UserId) && a.Password.Equals(loginCredential.Password)).FirstOrDefault();
                if (loginValue != null)
                {
                    Session[Emailid] = loginValue.UserId.ToString();
                    var email id = Session[Emailid].ToString();
                    Customer detail customerdetil = new customerdetails();
                    customerdetail = contxt.Custmerdetails.Where(y => y.Emailid == email id).first();
                    Session["UserName"] = customerdetail.customername;
                    Session["Custid"] = customerdetails.Custid;
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
            return View(loginCredential);
        }
        public ActionResult Logoff()
        {
            return View();
        }
    }
}