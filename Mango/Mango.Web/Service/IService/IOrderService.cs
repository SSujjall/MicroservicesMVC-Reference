﻿using Mango.Services.Web.Models;
using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IOrderService
    {
        Task<ResponseDto?> CreateOrder(CartDto cartDto);
    }
}
