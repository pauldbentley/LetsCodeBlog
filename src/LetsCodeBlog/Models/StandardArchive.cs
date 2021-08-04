using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace LetsCodeBlog.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
        /// <summary>
        /// The currently loaded post archive.
        /// </summary>
        public PostArchive<PostInfo> Archive { get; set; }

        [Region(Display = RegionDisplayMode.Setting)]
        public TemplateRegion Template { get; set; }
    }
}