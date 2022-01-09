using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VideoLibraryBusinessLayer
{
    public class Video
    {
        public int VideoId { get; set; }

        [StringLength(35)]
        public string Title { get; set; }

        //[Required(AllowEmptyStrings = true)]
        [Range(1974, 2017)]
        public int? Year { get; set; }
        public string Director { get; set; }
        public int Rating { get; set; }
        public string Plot { get; set; }
        public string PosterUrl { get; set; }

        public Collection<Review> Reviews { get; set; }
    }
}
