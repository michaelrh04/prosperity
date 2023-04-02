using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Client
{
    internal class Residential : IPurchasable
    {
        #region Public variables
        /// <summary>
        /// The name of the residence.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// <para>The location of the tile around the board, starting at Go.</para>
        /// <para>On the default board, this would mean 0 = Go, 10 = Jail/Just Visiting, 20 = Free Parking, and 30 = Go To Jail.</para>
        /// </summary>
        public int Location { get; }
        /// <summary>
        /// Returns a Brush representing the value of the set colour.
        /// </summary>
        public Brush Set { get; }
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
                return Rents[DevelopmentLevel];
            }
        }
        /// <summary>
        /// <para>Returns the level of development on this property.</para>
        /// <para>0 = property undeveloped; 1 = one house, etc.; 5 = hotel.</para>
        /// </summary>
        public int DevelopmentLevel { get; set; }
        /// <summary>
        /// Returns the cost of building houses and/or hotels (each) on this property.
        /// </summary>
        public int DevelopmentCost { get; }
        #endregion

        #region Private variables
        /// <summary>
        /// The rent brackets/tiers of this residential property, increasing from the property's undeveloped rental amount (at index 0) to its amount with a hotel constructed (at index 5).
        /// </summary>
        private int[] Rents = new int[6];
        #endregion

        #region INotifyPropertyChanged implementation
        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
