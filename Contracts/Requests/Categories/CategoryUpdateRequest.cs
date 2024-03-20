using Seminar3.Models;

namespace Seminar3.Contracts.Requests.Categories
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }


        public Category ProductGetEntity()
        {

            return new Category()
            {
                Id = Id,
                Name = Name,
                Description = Description

            };
        }
    }
}
