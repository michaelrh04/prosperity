using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Player : INotifyPropertyChanged
    {
        #region Variables
        /// <summary>
        /// The name of the player.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// <para>The number of attempts at rolling a double that a player has left before they must pay a fee to exit jail.</para>
        /// <para>This variable also serves as an indicator of whether or not a player is jailed (-1 = not jailed).</para>
        /// </summary>
        public int JailCounter { get; set; }
        #endregion

        #region INotifyPropertyChanged implementation
        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
