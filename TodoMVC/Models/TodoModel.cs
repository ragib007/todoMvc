using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TodoMVC.Models
{
    public class TodoModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Status TodoStatus { get; set; }

        public enum Status
        {
            Open,
            Done
        }

    }
}