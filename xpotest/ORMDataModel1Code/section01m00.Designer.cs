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

    public partial class section01m00 : XPLiteObject
    {
        string fsection_group_cd;
        [Key]
        [Size(5)]
        [ColumnDbDefaultValue("'Y'::bpchar")]
        public string section_group_cd
        {
            get { return fsection_group_cd; }
            set { SetPropertyValue<string>(nameof(section_group_cd), ref fsection_group_cd, value); }
        }
        string fsection_group_nm;
        [Size(255)]
        public string section_group_nm
        {
            get { return fsection_group_nm; }
            set { SetPropertyValue<string>(nameof(section_group_nm), ref fsection_group_nm, value); }
        }
        char fuse_yn;
        public char use_yn
        {
            get { return fuse_yn; }
            set { SetPropertyValue<char>(nameof(use_yn), ref fuse_yn, value); }
        }
    }

}
