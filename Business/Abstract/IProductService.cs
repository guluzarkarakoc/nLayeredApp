using Business.DTOs.Request;
using Business.DTOs.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
         Task<GetListProductResponse> GetListAsync( );
        Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);
    }
    //response request pattern
}
