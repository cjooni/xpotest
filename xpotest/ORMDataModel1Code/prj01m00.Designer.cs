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

    public partial class prj01m00 : XPLiteObject
    {
        string fproject_cd;
        [Key]
        [Size(10)]
        public string project_cd
        {
            get { return fproject_cd; }
            set { SetPropertyValue<string>(nameof(project_cd), ref fproject_cd, value); }
        }
        string fproject_nm;
        public string project_nm
        {
            get { return fproject_nm; }
            set { SetPropertyValue<string>(nameof(project_nm), ref fproject_nm, value); }
        }
        string fstart_dt;
        [Size(8)]
        public string start_dt
        {
            get { return fstart_dt; }
            set { SetPropertyValue<string>(nameof(start_dt), ref fstart_dt, value); }
        }
        string fend_dt;
        [Size(8)]
        public string end_dt
        {
            get { return fend_dt; }
            set { SetPropertyValue<string>(nameof(end_dt), ref fend_dt, value); }
        }
        string fclient_cd;
        [Size(10)]
        public string client_cd
        {
            get { return fclient_cd; }
            set { SetPropertyValue<string>(nameof(client_cd), ref fclient_cd, value); }
        }
        string fclient_id;
        [Size(8)]
        public string client_id
        {
            get { return fclient_id; }
            set { SetPropertyValue<string>(nameof(client_id), ref fclient_id, value); }
        }
    }

}
