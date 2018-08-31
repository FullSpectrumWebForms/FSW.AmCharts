using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FSW.AmCharts
{
    public enum GraphType
    {
        Line, Column, Step, SmoothedLine, Candlestick, Ohlc
    }

    public class GraphConfig
    {
        public string Id;
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GraphType GraphType;
        public string ValueField;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BalloonText = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool BehindColumns = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Bullet = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? BulletAlpha = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? BulletSize = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BulletSizeField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "color")]
        private string _Color = null;
        [JsonIgnore]
        public Color? Color
        {
            get => _Color is null ? (Color?)null : ColorTranslator.FromHtml(_Color);
            set => _Color = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ColorField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CustomBullet = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CustomBulletField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DateFormat = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float FillAlphas = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Color> FillColors = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FillColorsField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? FontSize = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ForceGap = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GapField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? GapPeriod = null;

        public enum GradientOrientationStyle
        {
            Vertical, Horizontal
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "gradientOrientation")]
        private string GradientOrientation_ = null;
        [JsonIgnore]
        public GradientOrientationStyle? GradientOrientation
        {
            get => GradientOrientation_ is null ? (GradientOrientationStyle?)null : (GradientOrientationStyle)Enum.Parse(typeof(GradientOrientationStyle), GradientOrientation_);
            set => GradientOrientation_ = value?.ToString().ToLower();
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Hidden = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int HideBulletsCount = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string HighField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IncludeInMinMax = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LabelAnchor = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LabelColorField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float LabelOffset = 0;

        public enum Position
        {
            Bottom, Top, Right, Left, Inside, Middle
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        private string LabelPosition_ = null;
        [JsonIgnore]
        public Position? LabelPosition
        {
            get => LabelPosition_ is null ? (Position?)null : (Position)Enum.Parse(typeof(Position), LabelPosition_);
            set => LabelPosition_ = value?.ToString().ToLower();
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float labelRotation = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LabelText = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? LegendAlpha = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "legendColor")]
        private string LegendColor_ = null;
        [JsonIgnore]
        public Color? LegendColor
        {
            get => LegendColor_ is null ? (Color?)null : ColorTranslator.FromHtml(LegendColor_);
            set => LegendColor_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LegendPeriodValueText = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LegendValueText = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? LineAlpha = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "lineColor")]
        private string LineColor_ = null;
        [JsonIgnore]
        public Color? LineColor
        {
            get => LineColor_ is null ? (Color?)null : ColorTranslator.FromHtml(LineColor_);
            set => LineColor_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LineColorField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? LineThickness = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LowField = null;

        public enum MarkerTypeStyle
        {
            Square, Circle, Diamond, TriangleUp, TriangleDown, TriangleLeft, Bubble, Line, None
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "gradientOrientation")]
        private string MarkerType_ = null;
        [JsonIgnore]
        public MarkerTypeStyle? MarkerType
        {
            get => MarkerType_ is null ? (MarkerTypeStyle?)null : (MarkerTypeStyle)Enum.Parse(typeof(MarkerTypeStyle), MarkerType_);
            set => MarkerType_ = value is null ? null : value.ToString().Substring(0, 1).ToLower() + value.ToString().Substring(1);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? MaxBulletSize = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? MinBulletSize = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? MinDistance = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float NegativeBase = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? NegativeFillAlphas = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "negativeFillColors")]
        private string NegativeFillColors_ = null;
        [JsonIgnore]
        public Color? NegativeFillColors
        {
            get => NegativeFillColors_ is null ? (Color?)null : ColorTranslator.FromHtml(NegativeFillColors_);
            set => NegativeFillColors_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? NegativeLineAlpha = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "negativeLineColor")]
        private string NegativeLineColor_ = null;
        [JsonIgnore]
        public Color? NegativeLineColor
        {
            get => NegativeLineColor_ is null ? (Color?)null : ColorTranslator.FromHtml(NegativeLineColor_);
            set => NegativeLineColor_ = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NewStack = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool NoStepRisers = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OpenField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PatternField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? PeriodSpan = null;
        public enum PointPositionStyle
        {
            Square, Circle, Diamond, TriangleUp, TriangleDown, TriangleLeft, Bubble, Line, None
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "pointPosition")]
        private string PointPosition_ = null;
        [JsonIgnore]
        public PointPositionStyle? PointPosition
        {
            get => PointPosition_ is null ? (PointPositionStyle?)null : (PointPositionStyle)Enum.Parse(typeof(PointPositionStyle), PointPosition_);
            set => PointPosition_ = value is null ? null : value.ToString().Substring(0, 1).ToLower() + value.ToString().Substring(1);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Precision = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ProCandlesticks = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ShowAllValueLabels = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ShowBalloon = null;

        public enum ShowBalloonAtStyle
        {
            Open, Close, High, Low, Top, Bottom
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "showBalloonAt")]
        private string ShowBalloonAt_ = null;
        [JsonIgnore]
        public ShowBalloonAtStyle? ShowBalloonAt
        {
            get => ShowBalloonAt_ is null ? (ShowBalloonAtStyle?)null : (ShowBalloonAtStyle)Enum.Parse(typeof(ShowBalloonAtStyle), ShowBalloonAt_);
            set => ShowBalloonAt_ = value is null ? null : value.ToString().Substring(0, 1).ToLower() + value.ToString().Substring(1);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "showBulletsAt")]
        private string ShowBulletsAt_ = null;
        [JsonIgnore]
        public ShowBalloonAtStyle? ShowBulletsAt
        {
            get => ShowBulletsAt_ is null ? (ShowBalloonAtStyle?)null : (ShowBalloonAtStyle)Enum.Parse(typeof(ShowBalloonAtStyle), ShowBulletsAt_);
            set => ShowBulletsAt_ = value is null ? null : value.ToString().Substring(0, 1).ToLower() + value.ToString().Substring(1);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ShowHandOnHover = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ShowOnAxis = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Stackable = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Position? StepDirection = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Switchable = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? TabIndex = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? TopRadius = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlTarget = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool UseLineColorForBulletBorder = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool UseNegativeColorIfDown = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? VisibleInLegend = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string XField = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string YField = null;
    }
    public enum ChartType
    {
        Serial
    }
}
