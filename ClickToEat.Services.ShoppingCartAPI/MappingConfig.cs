using AutoMapper;
using ClickToEat.Services.ShoppingCartAPI.Models;
using ClickToEat.Services.ShoppingCartAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickToEat.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
                config.CreateMap<Cart, CartDto>().ReverseMap();
                
            });

            return mappingConfig;
        }
    }
}
