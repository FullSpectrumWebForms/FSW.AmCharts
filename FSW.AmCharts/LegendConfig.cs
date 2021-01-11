using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FSW.AmCharts
{
    public class LegendConfig
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccessibleLabel;

        public enum AlignStyle
        {
            Left, Center, Right
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "align")]
        private string Align_ = null;
        [JsonIgnore]
        public AlignStyle? Align
        {
            get => Align_ is null ? (AlignStyle?)null : (AlignStyle)Enum.Parse(typeof(AlignStyle), Align_);
            set => Align_ = value is null ? null : value.ToString().Substring(0, 1).ToLower() + value.ToString().Substring(1);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AutoMargins;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float BackgroundAlpha;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "backgroundColor")]
        private string BackgroundColor_ = null;
        [JsonIgnore]
        public Color? BackgroundColor
        {
            get => BackgroundColor_ is null ? (Color?)null : ColorTranslator.FromHtml(BackgroundColor_);
            set => BackgroundColor_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float BorderAlpha;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "borderColor")]
        private string BorderColor_ = null;
        [JsonIgnore]
        public Color? BorderColor
        {
            get => BorderColor_ is null ? (Color?)null : ColorTranslator.FromHtml(BorderColor_);
            set => BorderColor_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? Bottom;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "color")]
        private string Color_ = null;
        [JsonIgnore]
        public Color? Color
        {
            get => Color_ is null ? (Color?)null : ColorTranslator.FromHtml(Color_);
            set => Color_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "combineLegend")]
        public bool CombineLegend;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "divId")]
        public string DivId;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "enabled")]
        public bool? Enabled;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "equalWidths")]
        public bool? EqualWidths;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "fontSize")]
        public float? FontSize;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "forceWidth")]
        public bool ForceWidth;

        public enum GradientRotationStyle
        {
            Rotate0 = 0, Rotate90 = 90, Rotate180 = 180, Rotate270 = 270
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "gradientRotation")]
        public GradientRotationStyle? GradientRotation;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "horizontalGap")]
        public float HorizontalGap;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "labelText")]
        public string LabelText;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "labelWidth")]
        public float? LabelWidth;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "left")]
        public float? Left;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "marginBottom")]
        public float MarginBottom;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "marginLeft")]
        public float? MarginLeft;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "marginRight")]
        public float? MarginRight;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "marginTop")]
        public float MarginTop;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderAlpha")]
        public float? MarkerBorderAlpha;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        private string MarkerBorderColor_ = null;
        [JsonIgnore]
        public Color? MarkerBorderColor
        {
            get => MarkerBorderColor_ is null ? (Color?)null : ColorTranslator.FromHtml(MarkerBorderColor_);
            set => MarkerBorderColor_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? MarkerBorderThickness;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerDisabledColor")]
        private string MarkerDisabledColor_ = null;
        [JsonIgnore]
        public Color? MarkerDisabledColor
        {
            get => MarkerDisabledColor_ is null ? (Color?)null : ColorTranslator.FromHtml(MarkerDisabledColor_);
            set => MarkerDisabledColor_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "valueWidth")]
        public float? ValueWidth;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "spacing")]
        public float? Spacing;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "valueAlign")]
        private string ValueAlign_ = null;
        [JsonIgnore]
        public AlignStyle? ValueAlign
        {
            get => ValueAlign_ is null ? (AlignStyle?)null : (AlignStyle)Enum.Parse(typeof(AlignStyle), ValueAlign_);
            set => ValueAlign_ = value is null ? null : value.ToString().Substring(0, 1).ToLower() + value.ToString().Substring(1);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "valueText")]
        public string ValueText;


        /*
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerDisabledColor")]
        public string markerDisabledColor;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerLabelGap")]
        public string markerLabelGap;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerSize")]
        public string markerSize;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerType")]
        public string markerType;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "maxColumns")]
        public string maxColumns;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "periodValueText")]
        public string periodValueText;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "position")]
        public string position;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "reversedOrder")]
        public string reversedOrder;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "right")]
        public string right;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "rollOverColor")]
        public string rollOverColor;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "rollOverGraphAlpha")]
        public string rollOverGraphAlpha;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "showEntries")]
        public string showEntries;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "switchable")]
        public string switchable;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string switchColor;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string switchType;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string tabIndex;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string textClickEnabled;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string top;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string useGraphSettings;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string useMarkerColorForLabels;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string useMarkerColorForValues;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string valueFunction;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string verticalGap;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "markerBorderColor")]
        public string width;
        */
    }
}
