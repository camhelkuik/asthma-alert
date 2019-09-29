using JsonApiDotNetCore.Models;

namespace AsthmaAlertApi.Models
{
    public class DustDander : Identifiable
    {
        [Attr("date")]
        public string Date { get; set; }

        [Attr("asthma-value")]
        public int AsthmaValue { get; set; }

        [Attr("asthma-category")]
        public string AsthmaCategory { get; set; }

        [Attr("dust-dander-value")]
        public int DustDanderValue { get; set; }

        [Attr("dust-dander-category")]
        public string DustDanderCategory { get; set; }
    }
}