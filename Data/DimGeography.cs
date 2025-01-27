﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFCoreBulk.Data
{
    public partial class DimGeography
    {
        public DimGeography()
        {
            DimCustomer = new HashSet<DimCustomer>();
            DimReseller = new HashSet<DimReseller>();
        }

        public int GeographyKey { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public string CountryRegionCode { get; set; }
        public string EnglishCountryRegionName { get; set; }
        public string SpanishCountryRegionName { get; set; }
        public string FrenchCountryRegionName { get; set; }
        public string PostalCode { get; set; }
        public int? SalesTerritoryKey { get; set; }
        public string IpAddressLocator { get; set; }

        public virtual DimSalesTerritory SalesTerritoryKeyNavigation { get; set; }
        public virtual ICollection<DimCustomer> DimCustomer { get; set; }
        public virtual ICollection<DimReseller> DimReseller { get; set; }
    }
}