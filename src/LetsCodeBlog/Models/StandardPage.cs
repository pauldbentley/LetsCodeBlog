using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace LetsCodeBlog.Models
{
    [PageType(Title = "Standard page")]
    public class StandardPage  : Page<StandardPage>
    {
        [Region(Display = RegionDisplayMode.Setting)]
        public TemplateRegion Template { get; set; }
    }
}