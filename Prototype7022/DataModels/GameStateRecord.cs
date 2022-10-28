using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype7022.DataModels
{
    // Each GameStateRecord is a record in the GameStates.csv file for a saved game state.
    // Whenever a player saves their game, they add a new entry to the GameStates.csv file.
    // Whenever they load a game, they take the record's info and load the referenced save file.
    // Whenever they delete a gamestate, they delete the referenced save file and then the record.
    // A CSV file is a performance measure - we don't want to load every save file at once.
    public enum Role
    {
        Fighter,
        Thief,
        Mage
    }
    class GameStateRecord
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime SaveDT { get; set; }
        public Role Role { get; set; }
        public int Level { get; set; }
        public float Story { get; set; }
        public string SFPath { get; set; }
    }
}
