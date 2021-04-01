using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApi.Models.ServiceModels;

namespace WebShopApi.Services
{
    public interface IProductServices
    {
        Task<bool> CreateBasicAsync(CreateBasicModel createBasicModel);
        Task<bool> CreateColorAsync(CreateColorModel createColorModel);
    }
}
