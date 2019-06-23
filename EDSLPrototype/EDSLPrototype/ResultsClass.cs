using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSLPrototype
{
    public class ResultsClass
    {
        public int GameNo { get; set; }
        public string hTeam { get; set; }
        public int hTeamGoals { get; set; }
        public string aTeam { get; set; }
        public int aTeamGoals { get; set; }

        public ResultsClass(int gNo, string home, string away, int aG, int hG)
        {
            gNo = GameNo;
            home = hTeam;
            away = aTeam;
            aG = aTeamGoals;
            hG = hTeamGoals;
        }
    }
}
