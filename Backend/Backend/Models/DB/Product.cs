﻿using System.ComponentModel.DataAnnotations;

namespace Backend.Models.DB
{

    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;


    }
}
