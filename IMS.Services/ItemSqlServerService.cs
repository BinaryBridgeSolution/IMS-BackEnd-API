using IMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.DataAccess;

namespace IMS.Services
{
    public class ItemSqlServerService : IitemRepository
    {
        private readonly IMS_DbContext _context = new IMS_DbContext();
        public List<Item> GetAllItems()
        {
            return _context.items.ToList();
        }

        public Item GetItemById(string ItemId)
        {
            return _context.items.Find(ItemId);
        }

        public Item AddItem(Item item)
        {
            _context.items.Add(item);
            _context.SaveChanges();
            return _context.items.Find(item.ItemId);
        }

        public void UpdateItem(Item item) 
        {
            _context.SaveChanges();
        }

        public void DeleteItem(Item item)
        {
           _context.Remove(item);
            _context.SaveChanges();
        }
    }
}
