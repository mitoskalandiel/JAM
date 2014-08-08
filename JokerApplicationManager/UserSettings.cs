using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JokerApplicationManager
{
    /// <summary>
    /// This class handles all user settings
    /// </summary>
    public class UserSettings
    {

        #region Private Variables

        #endregion

        #region Constructor
        /// <summary>
        /// UserSettings Constructor
        /// </summary>
        public UserSettings(){
            //initialization
        }

        #endregion

        /// <summary>
        /// Sets/Gets the amount of time for the statusbar updates to last
        /// </summary>
        /// <value name="StatusTimeout">Amount of seconds for timeout</value>
        public decimal StatusTimeout
        {
            get { return JokerApplicationManager.Properties.Settings.Default.StatusTimeOut; }
            set { JokerApplicationManager.Properties.Settings.Default.StatusTimeOut = value * 1000; }
        }

        /// <summary>
        /// Whether the application nsaves its settings during exit
        /// </summary>
        /// <value name="SaveOnExit">Boolean</value>
        public bool SaveOnExit
        {
            get { return JokerApplicationManager.Properties.Settings.Default.SaveOnExit; }
            set { JokerApplicationManager.Properties.Settings.Default.SaveOnExit = value; }
        }

        public void SaveSettings()
        {
            JokerApplicationManager.Properties.Settings.Default.Save();
        }

    }
}
