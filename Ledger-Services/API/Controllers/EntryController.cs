using Application.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : ControllerBase
    {
        

        private readonly ILogger<EntryController> _logger;

        private readonly IUnitOfWork _unitOfWork;

        public EntryController(ILogger<EntryController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

     
        [HttpGet("{id}")]
        public async Task<Entry> GetById(int id)
        {
            return await _unitOfWork.Entries.GetByIdAsync(1);

        }

        
    }
}