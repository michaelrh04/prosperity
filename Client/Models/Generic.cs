using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    internal class Generic : ILandable
    {
        #region Public variables
        /// <summary>
        /// The name of the station.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// <para>The location of the tile around the board, starting at Go.</para>
        /// <para>On the default board, this would mean 0 = Go, 10 = Jail/Just Visiting, 20 = Free Parking, and 30 = Go To Jail.</para>
        /// </summary>
        public int Location { get; }
        /// <summary>
        /// The type of generic tile this tile is (i.e., GO, Jail, Chance, etc.).
        /// </summary>
        public GenericTileTypeEnum Type { get; }
        #endregion

        #region INotifyPropertyChanged implementation
        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
