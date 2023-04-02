using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    /// <summary>
    /// The ViewModel for the GameWindow.xaml. Handles game data and operation.
    /// </summary>
    internal class GameViewModel : INotifyPropertyChanged
    {
        #region Public variables
        public ILandable[] Board { get; }
        #endregion

        #region INotifyPropertyChanged implementation
        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
