﻿// Type: Highsoft.Web.Mvc.Charts.ColumnrangeSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ColumnrangeSeriesStates : BaseObject
    {
        public ColumnrangeSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new ColumnrangeSeriesStatesHover();
        }

        public ColumnrangeSeriesStatesHover Hover { get; set; }

        private ColumnrangeSeriesStatesHover Hover_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Hover.IsDirty())
                hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
            return hashtable;
        }

        internal override string ToJSON()
        {
            Hashtable hashtable = this.ToHashtable();


            if (hashtable.Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}