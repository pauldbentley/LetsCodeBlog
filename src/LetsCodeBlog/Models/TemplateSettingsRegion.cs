using Piranha.Extend;
using Piranha.Extend.Fields;

namespace LetsCodeBlog.Models
{
    public class TemplateRegion
    {
        [Field]
        public HtmlField Footer { get; set; }

        [Field]
        public HtmlField Copywrite { get; set; }
    }
}
