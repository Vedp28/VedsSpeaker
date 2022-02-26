using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace VedSpeaker.Models
{
    public class SpeakerFeaturesViewModel
    {
        public List<Speaker> Speakers { get; set; }
        public SelectList Features { get; set; }
        public string SpeakerFeatures { get; set; }
        public string SearchString { get; set; }
    }
}
