using System;
using System.Collections.Generic;
using WebWorkshopManager.Shared.ENUMS;
using WebWorkshopManager.Shared.Models;

namespace WebWorkshopManager.Web.Base
{
    public static class NomenclaturesFactory
    {
        public static UserDto GetEmptyUserDto()
        {
            return new UserDto
            {
                Role = new RoleDto()
            };
        }

        public static RoleDto GetEmptyRoleDto()
        {
            return new RoleDto
            {
            };
        }

        public static CustomerDto GetEmptyCustomerDto()
        {
            return new CustomerDto
            {
                ContactNumber = "08"
            };
        }

        public static ProductDto GetEmptyProductDto(PRODUCT_TYPE productType)
        {
            return new ProductDto
            {
                ProductType = productType,
                QuantityInStock = 1.00M,
                UnitPrice = 0.00M,
            };
        }

        public static CarDto GetEmptyCarDto()
        {
            return new CarDto
            {
                Engine = new EngineDto()
                {
                    Name = string.Empty,
                    FuelType = FUEL_TYPE.NONE,
                    HorsePower = 0,
                }
            };
        }

        internal static JobItemDto GetEmptyJobItemDto()
        {
            return new JobItemDto
            {
                Description = string.Empty,
                Product = new ProductDto(),
                Quantity = 1,
            };
        }

        public static JobDto GetEmptyJobDto()
        {
            return new JobDto
            {
                Worker = new UserDto(),
                Car = new CarDto(),
                Customer = new CustomerDto(),
            };
        }
    }
}
