﻿// Type: Highsoft.Web.Mvc.Stocks.FlagsSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class FlagsSeriesStates : BaseObject
    {
        public FlagsSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new FlagsSeriesStatesHover();
        }

        public FlagsSeriesStatesHover Hover { get; set; }

        private FlagsSeriesStatesHover Hover_DefaultValue { get; set; }

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