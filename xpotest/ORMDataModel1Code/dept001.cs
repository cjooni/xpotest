﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xpotest.Tops
{

    public partial class dept001
    {
        public dept001(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}