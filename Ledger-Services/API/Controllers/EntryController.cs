using Application.Interfaces;
using Core.Entities;
using Core.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public EntryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        [Route("GetEntries")]
        [HttpPost]
        public async Task<IReadOnlyList<Entry>> Get(EntrySearchDTO search)
        {
            return await _unitOfWork.Entries.Get(search);

        }
        
        [Route("AddEntry")]
        [HttpPost]
        public async Task<int> Add(EntryDTO entry)
        {
            return await _unitOfWork.Entries.Add(entry);
        }


    }
}