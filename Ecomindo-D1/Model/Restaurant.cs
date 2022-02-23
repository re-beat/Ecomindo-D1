﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ecomindo_D1.Model
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid idRestaurant { get; set; }
        public string namaRestaurant { get; set; }
        [JsonIgnore]
        public List<Menu> Menus { get; set; }
    }
}
