using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel;
using System.Diagnostics;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ILogger<ExpenseController> _logger;
        private readonly AppDbContext _context;


        public ExpenseController(ILogger<ExpenseController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExpensePage()
        {
            var balances = _context.ExpenseTable.ToList();
            var totalBalance = balances.Sum(x => x.Amount);
            ViewBag.TotalBalance = totalBalance;
            return View(balances);
        }
        public IActionResult CreateOrEdit(int? id)
        {
            if (id != null)
            {
                var editInDb = _context.ExpenseTable.SingleOrDefault(x => x.Id == id);
                if (editInDb != null)
                {
                    return View(editInDb);
                }
            }

            return View();
        }
        public IActionResult Delete(int? id)
        {
            var RemoveInDb = _context.ExpenseTable.SingleOrDefault(x => x.Id == id);
            if (RemoveInDb != null)
            {
                _context.ExpenseTable.Remove(RemoveInDb);
                _context.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("ExpensePage");
        }

        public IActionResult CreateOrEditForm(Expense Yash)
        {
            if (Yash.Id == 0)
            {
                //Adding New Entry
                _context.ExpenseTable.Add(Yash);
            }
            else
            {
                //Updating Entry
                _context.ExpenseTable.Update(Yash);
            }

            _context.SaveChanges();
            return RedirectToAction("ExpensePage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
