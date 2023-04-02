using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Station : IPurchasable
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
        /// The owner of the property.
        /// </summary>
        public Player Owner { get; set; }
        /// <summary>
        /// The mortgage valuation of the property (i.e., the amount returned when mortgaged).
        /// </summary>
        public int MortgageValuation { get; }
        /// <summary>
        /// Returns the amount of rent due at this property.
        /// </summary>
        public int Rent
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region INotifyPropertyChanged implementation
        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
