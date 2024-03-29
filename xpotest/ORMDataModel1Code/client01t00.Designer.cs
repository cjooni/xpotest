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

    public partial class client01t00 : XPLiteObject
    {
        string femail;
        [Size(50)]
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>(nameof(email), ref femail, value); }
        }
        string fhp;
        [Size(14)]
        public string hp
        {
            get { return fhp; }
            set { SetPropertyValue<string>(nameof(hp), ref fhp, value); }
        }
        string foffice;
        [Size(14)]
        public string office
        {
            get { return foffice; }
            set { SetPropertyValue<string>(nameof(office), ref foffice, value); }
        }
        string fposition;
        [Size(3)]
        public string position
        {
            get { return fposition; }
            set { SetPropertyValue<string>(nameof(position), ref fposition, value); }
        }
        string fclient_id_nm;
        [Size(255)]
        public string client_id_nm
        {
            get { return fclient_id_nm; }
            set { SetPropertyValue<string>(nameof(client_id_nm), ref fclient_id_nm, value); }
        }
        public struct CompoundKey1Struct
        {
            [Size(10)]
            [Persistent("client_cd")]
            public string client_cd { get; set; }
            [Size(8)]
            [Persistent("client_id")]
            public string client_id { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
