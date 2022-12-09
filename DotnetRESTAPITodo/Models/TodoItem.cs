
using System.ComponentModel.DataAnnotations;

namespace DotnetRESTAPITodo.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Details { get; set; }


        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public bool IsComplete { get; set; }

        //Prevent over-posting
        public string? Secret { get; set; }
    }
}
