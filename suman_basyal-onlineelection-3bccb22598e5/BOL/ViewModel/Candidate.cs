using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.ViewModel
{
    public class Candidate
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string ElectionName { get; set; }
        public string ElectionDescription { get; set; }
        public DateTime EndDate { get; set; }
    }
}
