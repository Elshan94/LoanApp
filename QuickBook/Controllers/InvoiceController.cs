using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickBook.Business.Abstract;

namespace QuickBook.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        private readonly ILoanService _loanService;

        public InvoiceController(IInvoiceService invoiceService, ILoanService loanService)
        {
            _invoiceService = invoiceService;
            _loanService = loanService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddOrEdit(long? Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detail()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult Delete(long Id)
        {
            return View();
        }
    }
}