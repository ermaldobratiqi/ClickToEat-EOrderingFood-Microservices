using AutoMapper;
using ClickToEat.Services.CouponAPI.Models;
using ClickToEat.Services.CouponAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickToEat.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
                //config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                //config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
                //config.CreateMap<Cart, CartDto>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
