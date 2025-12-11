using AiTech.Entity.Entities.Common;

namespace AiTech.Entity.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public IList<Project> Projects { get; set; }


    }
}
