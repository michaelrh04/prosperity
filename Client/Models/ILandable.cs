using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    /// <summary>
    /// The interface for any landable tile. This covers all tiles in the game.
    /// </summary>
    internal interface ILandable : INotifyPropertyChanged
    {
        #region Variables
        // The name of the tile.
        string Name { get; }
        // The location of the tile around the board, starting at Go.</para>
        // On the default board, this would mean 0 = Go, 10 = Jail/Just Visiting, 20 = Free Parking, and 30 = Go To Jail.
        int Location { get; }
        #endregion
    }
}
