using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MainPlayerTeam
{
    //public abstract class Player
     public class Player 
    {
        // Fields
        private String _name;
        private String _team;
        private int _jerseyNumber;

        // Constructor
        public Player(string name, string team, int jerseyNumber)
        {
            //(<-)getters(->)setters
            _name = name; //get data from Player Class in^(parenthesis) & set this data to (<-)getters variable on left aka Private Fields
            _team = team;
            _jerseyNumber = jerseyNumber;
        }


        // Properties
        public string Name { get => _name; set => _name = value; }
        public string Team { get => _team; set => _name = value; }
        public int JerseyNumber { get => _jerseyNumber; set => _jerseyNumber = value; }

        // Methods or Method Modifiers (Virtual, New, Override)

    }
}
