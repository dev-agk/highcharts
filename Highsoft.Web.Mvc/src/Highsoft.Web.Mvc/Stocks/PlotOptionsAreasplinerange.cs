﻿// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreasplinerange


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsAreasplinerange : BaseObject
    {
        public PlotOptionsAreasplinerange()
        {
            bool? nullable1 = new bool?(false);
            this.AllowPointSelect_DefaultValue = nullable1;
            this.AllowPointSelect = nullable1;
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            double? nullable2 = new double?();
            this.AnimationLimit_DefaultValue = nullable2;
            this.AnimationLimit = nullable2;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            double? nullable3 = new double?();
            this.ColorIndex_DefaultValue = nullable3;
            this.ColorIndex = nullable3;
            this.Compare = this.Compare_DefaultValue = "undefined";
            this.CompareBase = this.CompareBase_DefaultValue = PlotOptionsAreasplinerangeCompareBase.Min;
            nullable1 = new bool?(false);
            this.ConnectNulls_DefaultValue = nullable1;
            this.ConnectNulls = nullable1;
            nullable3 = new double?(300.0);
            this.CropThreshold_DefaultValue = nullable3;
            this.CropThreshold = nullable3;
            this.Cursor = this.Cursor_DefaultValue = PlotOptionsAreasplinerangeCursor.Null;
            this.DashStyle = this.DashStyle_DefaultValue = PlotOptionsAreasplinerangeDashStyle.Solid;
            this.DataGrouping = this.DataGrouping_DefaultValue = new PlotOptionsAreasplinerangeDataGrouping();
            this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsAreasplinerangeDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable1;
            this.EnableMouseTracking = nullable1;
            this.Events = this.Events_DefaultValue = new PlotOptionsAreasplinerangeEvents();
            this.FillColor = this.FillColor_DefaultValue = (object) null;
            nullable3 = new double?(0.75);
            this.FillOpacity_DefaultValue = nullable3;
            this.FillOpacity = nullable3;
            nullable3 = new double?(0.0);
            this.GapSize_DefaultValue = nullable3;
            this.GapSize = nullable3;
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            nullable3 = new double?(0.0);
            this.LegendIndex_DefaultValue = nullable3;
            this.LegendIndex = nullable3;
            this.LineColor = this.LineColor_DefaultValue = "null";
            nullable3 = new double?(1.0);
            this.LineWidth_DefaultValue = nullable3;
            this.LineWidth = nullable3;
            this.Linecap = this.Linecap_DefaultValue = PlotOptionsAreasplinerangeLinecap.Round;
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            this.NavigatorOptions = this.NavigatorOptions_DefaultValue = (object) null;
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            this.Point = this.Point_DefaultValue = new PlotOptionsAreasplinerangePoint();
            nullable3 = new double?(1.0);
            this.PointInterval_DefaultValue = nullable3;
            this.PointInterval = nullable3;
            this.PointIntervalUnit =
                this.PointIntervalUnit_DefaultValue = PlotOptionsAreasplinerangePointIntervalUnit.Null;
            this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
            nullable3 = new double?(0.0);
            this.PointRange_DefaultValue = nullable3;
            this.PointRange = nullable3;
            nullable3 = new double?(0.0);
            this.PointStart_DefaultValue = nullable3;
            this.PointStart = nullable3;
            nullable1 = new bool?(false);
            this.Selected_DefaultValue = nullable1;
            this.Selected = nullable1;
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            nullable1 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable1;
            this.ShowCheckbox = nullable1;
            nullable1 = new bool?(true);
            this.ShowInLegend_DefaultValue = nullable1;
            this.ShowInLegend = nullable1;
            bool? nullable4 = new bool?();
            this.ShowInNavigator_DefaultValue = nullable4;
            this.ShowInNavigator = nullable4;
            this.Stacking = this.Stacking_DefaultValue = PlotOptionsAreasplinerangeStacking.Null;
            this.States = this.States_DefaultValue = new PlotOptionsAreasplinerangeStates();
            nullable4 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable4;
            this.StickyTracking = nullable4;
            this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsAreasplinerangeTooltip();
            nullable4 = new bool?(true);
            this.TrackByArea_DefaultValue = nullable4;
            this.TrackByArea = nullable4;
            nullable3 = new double?(1000.0);
            this.TurboThreshold_DefaultValue = nullable3;
            this.TurboThreshold = nullable3;
            nullable4 = new bool?(true);
            this.Visible_DefaultValue = nullable4;
            this.Visible = nullable4;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new List<PlotOptionsAreasplinerangeZone>();
        }

        public bool? AllowPointSelect { get; set; }

        private bool? AllowPointSelect_DefaultValue { get; set; }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public double? ColorIndex { get; set; }

        private double? ColorIndex_DefaultValue { get; set; }

        public string Compare { get; set; }

        private string Compare_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeCompareBase CompareBase { get; set; }

        private PlotOptionsAreasplinerangeCompareBase CompareBase_DefaultValue { get; set; }

        public bool? ConnectNulls { get; set; }

        private bool? ConnectNulls_DefaultValue { get; set; }

        public double? CropThreshold { get; set; }

        private double? CropThreshold_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeCursor Cursor { get; set; }

        private PlotOptionsAreasplinerangeCursor Cursor_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeDashStyle DashStyle { get; set; }

        private PlotOptionsAreasplinerangeDashStyle DashStyle_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeDataGrouping DataGrouping { get; set; }

        private PlotOptionsAreasplinerangeDataGrouping DataGrouping_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeDataLabels DataLabels { get; set; }

        private PlotOptionsAreasplinerangeDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeEvents Events { get; set; }

        private PlotOptionsAreasplinerangeEvents Events_DefaultValue { get; set; }

        public object FillColor { get; set; }

        private object FillColor_DefaultValue { get; set; }

        public double? FillOpacity { get; set; }

        private double? FillOpacity_DefaultValue { get; set; }

        public double? GapSize { get; set; }

        private double? GapSize_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public string LineColor { get; set; }

        private string LineColor_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeLinecap Linecap { get; set; }

        private PlotOptionsAreasplinerangeLinecap Linecap_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public object NavigatorOptions { get; set; }

        private object NavigatorOptions_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangePoint Point { get; set; }

        private PlotOptionsAreasplinerangePoint Point_DefaultValue { get; set; }

        public double? PointInterval { get; set; }

        private double? PointInterval_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangePointIntervalUnit PointIntervalUnit { get; set; }

        private PlotOptionsAreasplinerangePointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

        public PointPlacement PointPlacement { get; set; }

        private PointPlacement PointPlacement_DefaultValue { get; set; }

        public double? PointRange { get; set; }

        private double? PointRange_DefaultValue { get; set; }

        public double? PointStart { get; set; }

        private double? PointStart_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public bool? ShowCheckbox { get; set; }

        private bool? ShowCheckbox_DefaultValue { get; set; }

        public bool? ShowInLegend { get; set; }

        private bool? ShowInLegend_DefaultValue { get; set; }

        public bool? ShowInNavigator { get; set; }

        private bool? ShowInNavigator_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeStacking Stacking { get; set; }

        private PlotOptionsAreasplinerangeStacking Stacking_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeStates States { get; set; }

        private PlotOptionsAreasplinerangeStates States_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public PlotOptionsAreasplinerangeTooltip Tooltip { get; set; }

        private PlotOptionsAreasplinerangeTooltip Tooltip_DefaultValue { get; set; }

        public bool? TrackByArea { get; set; }

        private bool? TrackByArea_DefaultValue { get; set; }

        public double? TurboThreshold { get; set; }

        private double? TurboThreshold_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public List<PlotOptionsAreasplinerangeZone> Zones { get; set; }

        private List<PlotOptionsAreasplinerangeZone> Zones_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.AllowPointSelect;
            bool? nullable2 = this.AllowPointSelect_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? nullable3 = this.AnimationLimit;
            double? nullable4 = this.AnimationLimit_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "animationLimit", (object) this.AnimationLimit);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            nullable4 = this.ColorIndex;
            nullable3 = this.ColorIndex_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "colorIndex", (object) this.ColorIndex);
            if (this.Compare != this.Compare_DefaultValue)
                hashtable.Add((object) "compare", (object) this.Compare);
            if (this.CompareBase != this.CompareBase_DefaultValue)
                hashtable.Add((object) "compareBase",
                    (object) Highstock.FirstCharacterToLower(this.CompareBase.ToString()));
            nullable2 = this.ConnectNulls;
            nullable1 = this.ConnectNulls_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "connectNulls", (object) this.ConnectNulls);
            nullable3 = this.CropThreshold;
            nullable4 = this.CropThreshold_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highstock.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.DashStyle != this.DashStyle_DefaultValue)
                hashtable.Add((object) "dashStyle",
                    (object) Highstock.FirstCharacterToLower(this.DashStyle.ToString()));
            if (this.DataGrouping.IsDirty())
                hashtable.Add((object) "dataGrouping", (object) this.DataGrouping.ToHashtable());
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            nullable1 = this.EnableMouseTracking;
            nullable2 = this.EnableMouseTracking_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            if (this.FillColor != this.FillColor_DefaultValue)
                hashtable.Add((object) "fillColor", this.FillColor);
            nullable4 = this.FillOpacity;
            nullable3 = this.FillOpacity_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "fillOpacity", (object) this.FillOpacity);
            nullable3 = this.GapSize;
            nullable4 = this.GapSize_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "gapSize", (object) this.GapSize);
            nullable2 = this.GetExtremesFromAll;
            nullable1 = this.GetExtremesFromAll_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable4 = this.LegendIndex;
            nullable3 = this.LegendIndex_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.LineColor != this.LineColor_DefaultValue)
                hashtable.Add((object) "lineColor", (object) this.LineColor);
            nullable3 = this.LineWidth;
            nullable4 = this.LineWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            if (this.Linecap != this.Linecap_DefaultValue)
                hashtable.Add((object) "linecap", (object) Highstock.FirstCharacterToLower(this.Linecap.ToString()));
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            if (this.NavigatorOptions != this.NavigatorOptions_DefaultValue)
                hashtable.Add((object) "navigatorOptions", this.NavigatorOptions);
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable4 = this.PointInterval;
            nullable3 = this.PointInterval_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "pointInterval", (object) this.PointInterval);
            if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
                hashtable.Add((object) "pointIntervalUnit",
                    (object) Highstock.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
            if (this.PointPlacement.IsDirty())
            {
                nullable3 = this.PointPlacement.Value;
                if (nullable3.HasValue)
                    hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.Value);
                else
                    hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
            }
            nullable3 = this.PointRange;
            nullable4 = this.PointRange_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "pointRange", (object) this.PointRange);
            nullable4 = this.PointStart;
            nullable3 = this.PointStart_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "pointStart", (object) this.PointStart);
            nullable1 = this.Selected;
            nullable2 = this.Selected_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.Shadow.IsDirty())
                hashtable.Add((object) "shadow", (object) this.Shadow.ToHashtable());
            nullable2 = this.ShowCheckbox;
            nullable1 = this.ShowCheckbox_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
            nullable1 = this.ShowInLegend;
            nullable2 = this.ShowInLegend_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable2 = this.ShowInNavigator;
            nullable1 = this.ShowInNavigator_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "showInNavigator", (object) this.ShowInNavigator);
            if (this.Stacking != this.Stacking_DefaultValue)
                hashtable.Add((object) "stacking", (object) Highstock.FirstCharacterToLower(this.Stacking.ToString()));
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            nullable1 = this.StickyTracking;
            nullable2 = this.StickyTracking_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable2 = this.TrackByArea;
            nullable1 = this.TrackByArea_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "trackByArea", (object) this.TrackByArea);
            nullable3 = this.TurboThreshold;
            nullable4 = this.TurboThreshold_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
            nullable1 = this.Visible;
            nullable2 = this.Visible_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            if (this.ZoneAxis != this.ZoneAxis_DefaultValue)
                hashtable.Add((object) "zoneAxis", (object) this.ZoneAxis);
            if (this.Zones != this.Zones_DefaultValue)
                hashtable.Add((object) "zones", (object) this.HashifyList((IEnumerable) this.Zones));
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