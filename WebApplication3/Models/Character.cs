using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    /// <summary>
    /// Represents one specific character.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Unique id from sql.
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// character's name.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// The role of the specific character.
        /// </summary>
        public string Position { get; set; } = "";
    }
}