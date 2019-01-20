using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberdhips_1.Models
{
    public class ThumbnailAreaModel
    {
        public string Title { get; set; }
        public IEnumerable<ThumbnailModel> Thumbnails { get; set; }

    }
}