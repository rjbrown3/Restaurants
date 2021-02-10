using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Models
{
    public class Suggested
    {
        public string UserName { get; set; }
        public string RestName { get; set; }
        public string FavDish { get; set; }
        [Phone]     // make sure phone number is in a valid format
        [RegularExpression(@"^\(?([0-9]{3})\)?[-]([0-9]{3})[-]([0-9]{4})$", ErrorMessage = "Not a valid phone number: format as ###-###-####")]
        public string RestPhone { get; set; }
    }
}
