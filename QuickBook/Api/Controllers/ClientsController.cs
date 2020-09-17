using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickBook.Api.Services.Abstract;
using QuickBook.Models;

namespace QuickBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientApiService clientApiService;
        private readonly IMapper _mapper;
        public ClientsController( IClientApiService clientApiService, IMapper mapper)
        {
            _mapper = mapper;
            this.clientApiService = clientApiService;
        }


        [HttpGet]
        public object GetAllClients()
        {

            return Ok(_mapper.Map<List<ClientModel>>(clientApiService.GetAll()));
        }
    }
}