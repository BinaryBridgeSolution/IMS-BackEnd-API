using AutoMapper;
using IMS.Models;
using IMS.Services;
using IMS.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers
{
    [Route("api/ITM")]
    [ApiController]
    public class ITMController : ControllerBase
    {
        private readonly IitemRepository _service;
        private readonly IMapper _mapper;

        public ITMController(IitemRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<ItemDTO>> GetAllItems()
        {
            var items = _service.GetAllItems();

           var mappedItems = _mapper.Map<ICollection<ItemDTO>>(items);
            return Ok(mappedItems);
        }
        [HttpGet("{ItemId}", Name = "GetItem")]
        public IActionResult GetItems(string ItemId)
        {
            var item = _service.GetItemById(ItemId);
            if (item is null) 
            {
                return NotFound();
            }
            var mappedItems = _mapper.Map<ItemDTO>(item);
              //  _mapper.Map<ICollection<ItemDTO>>(item);
            
            return Ok(mappedItems);
        }
        [HttpPost]
        public ActionResult<ItemDTO> CreateItem(CreateItemDTO item)
        {

            var ItemEntity = _mapper.Map<Item>(item);
            var newItem = _service.AddItem(ItemEntity);

            var itemForReturn = _mapper.Map<ItemDTO>(newItem);

            return CreatedAtRoute("GetItem", new { ItemId = itemForReturn.ItemId},
                itemForReturn);
        }
        [HttpPut("{ItemId}")]
        public ActionResult UpdateItem(string ItemId,UpdateItemDTO item)
        {
            var updatingItem = _service.GetItemById(ItemId);

            if (updatingItem is null)
            {

                return NotFound(); 
            }
            _mapper.Map(item, updatingItem);
            _service.UpdateItem(updatingItem);
            return NoContent();
        
        }
        [HttpDelete("{ItemId}")]
        public ActionResult DeleteItem(string ItemId) 
        {
            var DeletingItem = _service.GetItemById(ItemId);

            if (DeletingItem is null)
            {

                return NotFound();
            }
            _service.DeleteItem(DeletingItem);
            return NoContent();
        }
    }
}
