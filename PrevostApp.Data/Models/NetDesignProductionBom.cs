﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PrevostApp.Data.Models
{
    public partial class NetDesignProductionBom
    {
        public int DesignBomNo { get; set; }
        public int DesignTool { get; set; }
        public int DesignItemNo { get; set; }
        public int QuoteNo { get; set; }
        public int Version { get; set; }
        public int Order { get; set; }
        public int ComponentType { get; set; }
        public string ArticleDeBase { get; set; }
        public string ArticlePref { get; set; }
        public string ComponentNo { get; set; }
        public string ProjectNo { get; set; }
        public string SortName { get; set; }
        public decimal QuantityPer { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal Scrap { get; set; }
        public string RoutingLinkCode { get; set; }
        public DateTime CreationTimestamp { get; set; }
        public string CreationUser { get; set; }
        public DateTime ModificationTimestamp { get; set; }
        public string ModificationUser { get; set; }
    }
}