using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FSW.AmCharts
{
    public class AxisConfig
    {

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float LabelRotation = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? LabelsEnabled = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Offset = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuideConfig> Guides = null;

        public enum Position
        {
            Bottom, Top, Right, Left
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        private string LabelPosition_ = null;
        [JsonIgnore]
        public Position? AxePosition
        {
            get => LabelPosition_ is null ? (Position?)null : (Position)Enum.Parse(typeof(Position), LabelPosition_);
            set => LabelPosition_ = value?.ToString().ToLower();
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? TitleBold = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "titleColor")]
        private string _titleColor = null;
        [JsonIgnore]
        public Color? TitleColor
        {
            get => _titleColor is null ? (Color?)null : ColorTranslator.FromHtml(_titleColor);
            set => _titleColor = value is null ? null : ColorTranslator.ToHtml(value.Value);
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? TitleFontSize = null;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? TitleRotation = null;
    }
}
