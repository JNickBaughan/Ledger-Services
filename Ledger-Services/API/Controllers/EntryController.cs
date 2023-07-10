using Application.Interfaces;
using Core.Entities;
using Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : ControllerBase
    {
        

        private readonly ILogger<EntryController> _logger;

        private readonly IUnitOfWork<Entry, EntrySearch> _unitOfWork;

        public EntryController(ILogger<EntryController> logger, IUnitOfWork<Entry, EntrySearch> unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

     
        [HttpPost]
        public async Task<IReadOnlyList<Entry>> Get(EntrySearch search)
        {
            return await _unitOfWork.Entries.Get(search);

        }

        
    }
}