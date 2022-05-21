using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace IO.Swagger.Models
{
    public class Obs
    {
        [Required]
        [DataMember(Name = "alive")]
        public IList<int> Alive { get; set; }
    }
}
