﻿using Grand.Infrastructure.Models;
using Grand.Web.Models.Common;

namespace Grand.Web.Models.Customer
{
    public class CustomerAddressEditModel : BaseModel
    {
        public AddressModel Address { get; set; } = new();
    }
}