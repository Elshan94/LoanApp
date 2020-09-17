using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickBook.Api.Services.Abstract;
using QuickBook.Entities.Concrete;
using QuickBook.Models;

namespace QuickBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly ILoanApiService _service;
        private readonly IClientApiService clientApiService;
        private readonly IMapper _mapper;
        public LoansController(ILoanApiService service, IClientApiService clientApiService, IMapper mapper) {

            _service = service;
            _mapper = mapper;
            this.clientApiService = clientApiService;
        }


        [HttpGet]
        public object GetAllLoans()
        {

            return Ok(_mapper.Map<List<LoanModel>>( _service.GetAll()));
        }

        [HttpGet("{Id:int}")]
        public object GetLoan(long Id)
        {
            return Ok(_mapper.Map<LoanModel>( _service.GetById(Id)));
        }

        [HttpPost]
        public object AddLoan(LoanModel model)
        {
            Loan mappedModel = _mapper.Map<Loan>(model);
            var response = _service.Create(mappedModel);
            return Ok(response) ;
        }

       

    }
}