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

    public partial class mass_calc : XPLiteObject
    {
        decimal fyongsu_m2;
        [ColumnDbDefaultValue("NULL::numeric")]
        public decimal yongsu_m2
        {
            get { return fyongsu_m2; }
            set { SetPropertyValue<decimal>(nameof(yongsu_m2), ref fyongsu_m2, value); }
        }
        decimal fstone_flour_m2;
        [ColumnDbDefaultValue("NULL::numeric")]
        public decimal stone_flour_m2
        {
            get { return fstone_flour_m2; }
            set { SetPropertyValue<decimal>(nameof(stone_flour_m2), ref fstone_flour_m2, value); }
        }
        decimal foverlay_asp;
        [ColumnDbDefaultValue("NULL::numeric")]
        public decimal overlay_asp
        {
            get { return foverlay_asp; }
            set { SetPropertyValue<decimal>(nameof(overlay_asp), ref foverlay_asp, value); }
        }
        decimal foverlay_asp_con;
        [ColumnDbDefaultValue("NULL::numeric")]
        public decimal overlay_asp_con
        {
            get { return foverlay_asp_con; }
            set { SetPropertyValue<decimal>(nameof(overlay_asp_con), ref foverlay_asp_con, value); }
        }
        public struct CompoundKey1Struct
        {
            [Size(10)]
            [Persistent("project_cd")]
            public string project_cd { get; set; }
            [Persistent("key")]
            public long key { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}