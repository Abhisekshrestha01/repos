using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.ViewModel
{
    public class VotingViewModel
    {
        public List<Item> electionList { get; set; }
        public CastVoteViewModel castVoteViewModel { get; set; }
        public List<Item> candidateList { get; set; }
    }
}
