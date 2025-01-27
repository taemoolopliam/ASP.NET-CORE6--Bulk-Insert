﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFCoreBulk.Data
{
    public partial class DimPromotion
    {
        public DimPromotion()
        {
            FactInternetSales = new HashSet<FactInternetSales>();
            FactResellerSales = new HashSet<FactResellerSales>();
        }

        public int PromotionKey { get; set; }
        public int? PromotionAlternateKey { get; set; }
        public string EnglishPromotionName { get; set; }
        public string SpanishPromotionName { get; set; }
        public string FrenchPromotionName { get; set; }
        public double? DiscountPct { get; set; }
        public string EnglishPromotionType { get; set; }
        public string SpanishPromotionType { get; set; }
        public string FrenchPromotionType { get; set; }
        public string EnglishPromotionCategory { get; set; }
        public string SpanishPromotionCategory { get; set; }
        public string FrenchPromotionCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MinQty { get; set; }
        public int? MaxQty { get; set; }

        public virtual ICollection<FactInternetSales> FactInternetSales { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSales { get; set; }
    }
}