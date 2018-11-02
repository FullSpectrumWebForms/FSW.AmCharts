using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FSW.AmCharts
{
    public class GuideConfig
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Above = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "balloonColor")]
        private string _balloonColor = null;
        [JsonIgnore]
        public Color? BalloonColor
        {
            get => _balloonColor is null ? (Color?)null : ColorTranslator.FromHtml(_balloonColor);
            set => _balloonColor = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BalloonText = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool BoldLabel = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Category = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "color")]
        private string _color = null;
        [JsonIgnore]
        public Color? Color
        {
            get => _color is null ? (Color?)null : ColorTranslator.FromHtml(_color);
            set => _color = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? FillAlpha = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? DashLength = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? FontSize = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Inside = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Label = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? LabelRotation = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? LineAlpha = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "lineColor")]
        private string _lineColor = null;
        [JsonIgnore]
        public Color? LineColor
        {
            get => _lineColor is null ? (Color?)null : ColorTranslator.FromHtml(_lineColor);
            set => _lineColor = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? LineThickness = null;


        public enum Position
        {
            Bottom, Top, Right, Left
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "labelPosition")]
        private string _LabelPosition = null;
        [JsonIgnore]
        public Position? LabelPosition
        {
            get => _LabelPosition is null ? (Position?)null : (Position)Enum.Parse(typeof(Position), _LabelPosition);
            set => _LabelPosition = value?.ToString().ToLower();
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ToCategory = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? ToValue = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? Value = null;

    }
}
