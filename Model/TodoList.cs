using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace TodoMini.Model
{
    public class TodoList
    {
		[Key]
		public int Id { get; set; }

		[BindProperty]

		 public string? Title { get; set; }

		[BindProperty]

		 public string? Description { get; set; }

		[BindProperty]

		 public string? Date { get; set; }

		



    }
}
