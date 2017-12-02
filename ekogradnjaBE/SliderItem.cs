using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekogradnjaBE
{
    public class SliderItem : BaseEntity
    {
        [SqlFieldNameAttribute("imageUrl")]
        public string ImageUrl { get; set; }

        [SqlFieldNameAttribute("sortIndex")]
        public int SortIndex { get; set; }

        [SqlFieldNameAttribute("url")]
        public string Url { get; set; }

        [SqlFieldNameAttribute("caption")]
        public string Caption { get; set; }

        public SliderItem()
        {

        }

        public SliderItem(int id, string imageUrl, int sortIndex, string url, string caption)
        {
            this.ID = id;
            this.ImageUrl = imageUrl;
            this.SortIndex = sortIndex;
            this.Url = url;
            this.Caption = caption;
        }
    }
}
