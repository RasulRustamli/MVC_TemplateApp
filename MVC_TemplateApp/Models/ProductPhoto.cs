using MVC_TemplateApp.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_TemplateApp.Models;

public class ProductPhoto:BaseEntity
{
    public Guid ProductId { get; set; }
    public bool isMain { get; set; }
    public Product Product { get; set; } = null!;
    public string Url { get; set; } = null!;
    [NotMapped]
    public override DateTime ModifiedDate { get; set; }
}

 
 