using AiTech.Entity.Entities.Common;

namespace AiTech.Entity.Entities
{
    public class AboutItem : BaseEntity
    {
        public string TitleName { get; set; }

        public About About { get; set; }
        public int AboutId { get; set; }


    }
}
