using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickBook.Business.Abstract;
using QuickBook.Entities.Concrete;
using QuickBook.Models;

namespace QuickBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoanService _loanService;
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public static string Name = "Home";
        public HomeController( ILoanService loanService, IClientService clientService, IMapper mapper)
        {
            _loanService = loanService;
            _clientService = clientService;
            _mapper = mapper;

        }
        public async Task<IActionResult> Index()
        {
            var models = _mapper.Map<List<LoanModel>>(await _loanService.GetAllWithClients());
            return View(models);
        }
    

        [HttpGet]
        public async Task<IActionResult>  AddOrEdit(long Id)
        {
            ViewBag.Clients = _mapper.Map<List<ClientModel>>( await _clientService.GetAllAsync());
            if(Id!= default)
            {
                return View(_mapper.Map<LoanModel>(await _loanService.GetByIdWithInvoices(Id)));
            }
            return View(new LoanModel());
        }

        [HttpPost]
        public async Task<IActionResult>  AddOrEdit(LoanModel model)
        {
            long id = default;
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Loan>(model);
                await _loanService.AddAsync(entity);
                return RedirectToAction("Detail", new { Id= entity.Id});
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult>  Detail(long Id)
        {
                return View(_mapper.Map<LoanModel>(await _loanService.GetByIdWithInvoices(Id)));
        }

        [HttpDelete]
        public IActionResult Delete(long Id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CalculateInvoices(decimal amount, int period, decimal interestRate, DateTime DueDate)
        {
            var result = _loanService.CalculateInvoices(amount, period, interestRate, DueDate);
            return Json(JsonConvert.SerializeObject(result));
        }


    }
}