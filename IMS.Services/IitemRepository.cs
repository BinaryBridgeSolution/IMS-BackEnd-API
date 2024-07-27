using IMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services
{
    public interface IitemRepository
    {
        public List<Item> GetAllItems();
        public Item GetItemById(string ItemId);

        public Item AddItem(Item item);
        public void UpdateItem(Item item);
        public void DeleteItem(Item item);
    }
}
