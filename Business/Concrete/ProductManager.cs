using Business.Abstract;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTOs.Responses;
using Business.DTOs.Request;
using Microsoft.Identity.Client;
using AutoMapper;

namespace Business.Concrete
{
    public class ProductManager: IProductService
    {

        IProductDal _productDal;
        IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

      
        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)

        {
            Product product = _mapper.Map<Product>(createProductRequest);
            Product createdProduct = await _productDal.AddAsync(product);
            CreatedProductResponse createdProductResponse = _mapper.Map<CreatedProductResponse>(createdProduct);
            return createdProductResponse;

          
        }

           public async Task<GetListProductResponse> GetListAsync()
            {
                IPaginate<Product> products = await _productDal.GetListAsync();
                GetListProductResponse mapped = _mapper.Map<GetListProductResponse>(products);
                return mapped;
            }





        



    }
}
