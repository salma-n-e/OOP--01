using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDelivery
{
    public struct Models
    {
       
        //1  DeliveryAddress struct
       
        
            public string city;
            public string street;
            public int BuildingNumber;
            public Models (string city, string street, int buildingNumber)
            {
                this.city = city;
                this.street = street;
                this.BuildingNumber = buildingNumber;
            }
            public string GetFullAddress()
            {
                return $"{city}, {street}, {BuildingNumber}";

            }
}
}
