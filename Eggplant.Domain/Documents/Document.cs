using Eggplant.Domain.Common;

namespace Eggplant.Domain.Documents
{
    public class Document : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}