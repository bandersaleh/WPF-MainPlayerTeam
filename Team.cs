using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MainPlayerTeam
{
    public class Team
    {
        // Fields
        private string _teamName;
        private string _teamCity;
        private int _teamRank;

        // Constructors
        public Team(string teamName, string teamCity, int teamRank)
        {
            _teamName = teamName;
            _teamCity = teamCity;
            _teamRank = teamRank;
        }
        
        // Properties
        public string TeamName { get => _teamName; set => _teamName = value; }
        public string TeamCity { get => _teamCity; set => _teamCity = value; }
        public int TeamRank { get => _teamRank; set => _teamRank = value; }

        // Methods or Method Modifiers (Virtual, New, Override)
        
    }
}
