using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [ForeignKey("Stock")]
        //connect the comments to the stock model
        public int? StockId { get; set; }
        //Navigation property -> allows us to navigate within our models
        public Stock? Stock { get; set; }

    }
}