using AutoMapper;
using Business.DTOs.Request;
using Business.DTOs.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Profiles
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, CreatedProductResponse>();
            CreateMap<CreateProductRequest, Product >();

          //  CreateMap<Product, GetListProductResponse>();

            CreateMap<IPaginate<Product>, GetListProductResponse>();
            CreateMap<Product, ListProductDto>();

        }
    }
}
