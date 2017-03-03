using System.Collections.Generic;

namespace Vidly.Controllers.API
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}