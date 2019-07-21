using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xpotest.Tops
{

    public partial class mass_calc
    {
        public mass_calc(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
