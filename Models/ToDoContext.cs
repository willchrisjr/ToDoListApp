   using Microsoft.EntityFrameworkCore;

   namespace ToDoListApp.Models
   {
       public class ToDoContext : DbContext
       {
           public DbSet<ToDoItem> ToDoItems { get; set; }

           public ToDoContext(DbContextOptions<ToDoContext> options)
               : base(options)
           {
           }
       }
   }