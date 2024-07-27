using AutoMapper;
using IMS.Models;
using IMS.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemDTO>(); // if needed we can conquete two fields, there is an option            
            CreateMap<CreateItemDTO, Item>();
            CreateMap<UpdateItemDTO, Item>();
        }
    }
}
