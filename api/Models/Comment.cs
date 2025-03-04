using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        //connect the comments to the stock model
        public int? StockId { get; set; }
        //Navigation property -> allows us to navigate within our models
        public Stock? Stock { get; set; }

    }
}