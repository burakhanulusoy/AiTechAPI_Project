using AiTech.Entity.Entities.Common;

namespace AiTech.Entity.Entities
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IList<AboutItem> AboutItems { get; set; }

    }
}
