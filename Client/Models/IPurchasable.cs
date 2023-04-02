using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    /// <summary>
    /// The interface for any purchasable/ownable tile. This covers all properties, stations, and utilities.
    /// </summary>
    internal interface IPurchasable : ILandable
    {
        #region Variables
        // The owner of the property.
        Player Owner { get; set; }
        // Returns the amount of rent due when requested.
        int Rent { get; }
        // The mortgage valuation of the property (i.e., the amount returned when mortgaged).
        int MortgageValuation { get; }
        #endregion
    }
}
