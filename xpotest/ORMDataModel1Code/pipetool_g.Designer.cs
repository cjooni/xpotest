﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xpotest.Tops
{

    public partial class pipetool_g : XPLiteObject
    {
        string fmeasure_point;
        [Size(20)]
        public string measure_point
        {
            get { return fmeasure_point; }
            set { SetPropertyValue<string>(nameof(measure_point), ref fmeasure_point, value); }
        }
        decimal finv;
        public decimal inv
        {
            get { return finv; }
            set { SetPropertyValue<decimal>(nameof(inv), ref finv, value); }
        }
        decimal fdia;
        public decimal dia
        {
            get { return fdia; }
            set { SetPropertyValue<decimal>(nameof(dia), ref fdia, value); }
        }
        string ftext;
        [Size(20)]
        public string text
        {
            get { return ftext; }
            set { SetPropertyValue<string>(nameof(text), ref ftext, value); }
        }
        long fsheet_index;
        public long sheet_index
        {
            get { return fsheet_index; }
            set { SetPropertyValue<long>(nameof(sheet_index), ref fsheet_index, value); }
        }
        public struct CompoundKey1Struct
        {
            [Size(10)]
            [Persistent("project_cd")]
            public string project_cd { get; set; }
            [Persistent("id")]
            public long id { get; set; }
            [Size(30)]
            [Persistent("line_info")]
            public string line_info { get; set; }
            [Size(20)]
            [Persistent("sheet_info")]
            public string sheet_info { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
