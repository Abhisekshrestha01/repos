using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.ViewModel
{
    public class ResultViewModel
    {
        public int candidateId { get; set; }
        public int totalVotes { get; set; }
        public string Name { get; set; }
        public DateTime EndTime { get; set; }
        public string EndTimeString { get; set; }
    }
}
