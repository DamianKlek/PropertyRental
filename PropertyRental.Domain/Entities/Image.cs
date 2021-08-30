using PropertyRental.Domain.Common;

namespace PropertyRental.Domain.Entities
{
  public class Image : AuditableEntity
  {
    public string Name { get; set; }
    public string SourcePath { get; set; }
    public int PropertyId { get; set; }
    public Property Property { get; set; }
  }
}
