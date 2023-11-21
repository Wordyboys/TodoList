using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoMini.Model;

namespace TodoMini.Pages
{
    public class TodoModel : PageModel
    {
       

		private readonly DBMemory dBMemory;	

		public List<TodoList> Todo { get; set; } = new List<TodoList>();

        [BindProperty]
        public TodoList NewList { get; set; } 

        public TodoModel(DBMemory context)
        {
            dBMemory= context;
        }

        public void OnGet()
        {
            Todo = dBMemory.Todo.ToList();
        }

		public IActionResult OnPost()
        {
   
            dBMemory.Todo.Add(NewList);

                dBMemory.SaveChanges();
                return RedirectToPage();
 
       
        }

    }
}
