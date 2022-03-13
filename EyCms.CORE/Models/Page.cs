using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyCms.CORE.Models
{
    public class Page:BaseEntity
    {
        public string Name { get; set; }
        public string SeoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
    }
}
