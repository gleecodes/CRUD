  using System.ComponentModel.DataAnnotations;
    using System;
    namespace CRUD.Models
    {
        public class Dishes
        {
            // auto-implemented properties need to match the columns in your table
            // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
            [Key]
            public int Id { get; set; }
            // MySQL VARCHAR and TEXT types can be represeted by a string
            [Required]
            [Display(Name = "Name of Dish")]
            public string Name { get; set; }
            [Required]
            [Display(Name="Chef's Name")]
            public string Chef { get; set; }
            [Required]
            public int Tastiness { get; set; }
            
            [Required]
            public int Calories { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            // The MySQL DATETIME type can be represented by a DateTime
            public DateTime  CreatedAt {get;set;}
            [Required]
            public DateTime UpdatedAt {get;set;}
        }
    }
    