using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace xpotest.Tops
{

    public partial class pipetool_tree
    {
        public pipetool_tree(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
