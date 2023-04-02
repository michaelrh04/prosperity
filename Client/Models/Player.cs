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
        #endregion

        #region INotifyPropertyChanged implementation
        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
