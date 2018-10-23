using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class ElectionValidation
    {
        [Required]
       
        public System.DateTime startDate { get; set; }

       
    }

    [MetadataType(typeof(ElectionValidation))]
    public partial class Election
    {
        public List<string> listOfCandidates { get; set; }

        public List<string> listOfVoters { get; set; }

        
    }
}
