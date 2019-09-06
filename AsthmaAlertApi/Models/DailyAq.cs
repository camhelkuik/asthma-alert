using JsonApiDotNetCore.Models;

namespace AsthmaAlertApi.Models
{
    public class DailyAq : Identifiable
    {
        [Attr("date")]
        public string Date { get; set; }

        [Attr("ozone-value")]
        public int OzoneValue { get; set; }

        [Attr("ozone-category")]
        public string OzoneCategory { get; set; }

        [Attr("grass")]  
        public int Grass { get; set; }

        [Attr("mold")]
        public int Mold { get; set; }

        [Attr("ragweed")]
        public int Ragweed { get; set; }

        [Attr("tree")]
        public int Tree { get; set; }

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