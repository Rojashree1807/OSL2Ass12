using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAss12.Models
{
    public class CricketTeam
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int NOWC { get; set; }

        internal static void Add(CricketTeam team)
        {
            throw new NotImplementedException();
        }
    }
}