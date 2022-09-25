namespace MVC_TemplateApp.Models.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
