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

    public partial class dept001 : XPLiteObject
    {
        string fdept_cd;
        [Key]
        [Size(5)]
        public string dept_cd
        {
            get { return fdept_cd; }
            set { SetPropertyValue<string>(nameof(dept_cd), ref fdept_cd, value); }
        }
        string fdept_nm;
        [Size(50)]
        public string dept_nm
        {
            get { return fdept_nm; }
            set { SetPropertyValue<string>(nameof(dept_nm), ref fdept_nm, value); }
        }
    }

}
