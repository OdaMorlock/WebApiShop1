using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApi.Models.ServiceModels
{
    public class CreateColorModel
    {
        public string ColorName { get; set; }
        public string ColorHex { get; set; }
    }
}
