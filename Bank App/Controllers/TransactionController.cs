using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank_App.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult MakeTransaction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MakeTransaction([Bind(Include = "TransactionType")] TransactionDetailModel transactiondetail)
        {
            Session[TransactionType] = transactiondetail.transactiontype;
            if(Session[TransactionType].ToString() == 'Withdraw')
            {
                return RedirectToAction("")
            }
            else (Session[TransactionType] == 'Transfer')
            {
                return RedirectToAction("Transfer")
            }
            else rerturn httpnotfound()
;        }
        public ActionResult Transfer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Transfer([Bind(Include = "Fromacc, Toacc, amo")] TransactionDetailModel transactiondetail)
        {
            if (ModelState.IsValid)
            {
                List<> trans = new List<T>();
                trans = amountTransactedPerDay = ContextBoundObject.table.where(x => x.trasferdate = currdate amd x.from = Fromacc).ToList();
                int amountTransactedPerDay = Ammountlist.Select(x => x.amountTransferred).Sum();
                if (toacc exists) && (amou > 0) (aMT < BALANCE) && (amountTransactedPerDay <5000) {
                    movieDetail.tt = Session[TransactionType].ToString();
                    movie.tdate = DateTime.Now;
                    db.movieDetails.Add(movieDetail);
                    //find the account details record and update simultaenuosly before saving
                    db.SaveChanges();
                    return RedirectToAction("ViewMovies");
                }

            }

            return View(movieDetail);
            ;
        }
        public ActionResult Withdraw()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Withdraw([Bind(Include = "Fromacc, amo")] TransactionDetailModel transactiondetail)
        {
            if (ModelState.IsValid)
            {
                if (amou > 0)
                {
                    movieDetail.tt = Session[TransactionType].ToString();
                    movie.tdate = DateTime.Now;
                    db.movieDetails.Add(movieDetail);
                    //find the account details record and update simultaenuosly before saving
                    db.SaveChanges();
                    return RedirectToAction("ViewMovies");
                }

            }

            return View(movieDetail);
            ;
        }
    }
}