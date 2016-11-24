using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCdesdecero_OtraPrueba.Models
{
    public class ProductView
    {
        [Key] //<-- el tributo ID va ser el codigo del producto o clave autonumerica
        public int ProductID { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime LastBuy { get; set; }

        public float Stock { get; set; }
    }
}