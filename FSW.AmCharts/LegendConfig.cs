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

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CombineLegend;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DivId;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Enabled;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EqualWidths;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? FontSize;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ForceWidth;

        public enum GradientRotationStyle
        {
            Rotate0 = 0, Rotate90 = 90, Rotate180 = 180, Rotate270 = 270
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GradientRotationStyle? GradientRotation;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float HorizontalGap;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LabelText;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? LabelWidth;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? Left;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float MarginBottom;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? MarginLeft;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? MarginRight;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float MarginTop;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
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

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string markerDisabledColor;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string markerLabelGap;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string markerSize;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string markerType;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string maxColumns;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string periodValueText;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string position;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string reversedOrder;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string right;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string rollOverColor;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string rollOverGraphAlpha;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string showEntries;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string spacing;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string switchable;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string switchColor;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string switchType;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string tabIndex;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string textClickEnabled;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string top;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string useGraphSettings;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string useMarkerColorForLabels;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string useMarkerColorForValues;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string valueAlign;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string valueFunction;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string valueText;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string valueWidth;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string verticalGap;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string width;

    }
}
