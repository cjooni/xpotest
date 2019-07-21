using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xpotest.Tops
{

    public partial class pipetool_g
    {
        public pipetool_g(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
