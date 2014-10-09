using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JokerAPI;

namespace JokerApplicationManager
{
    /// <summary>
    /// This class handles all user settings.
    /// NOTE: This is a singleton, ensuring that only one instance exists and no duplicate settings are being saved/used
    /// </summary>
    public sealed class UserSettings
    {
        private const string SettingsFileName = "JAM-Settings.xml";
        private const string internalPassPhrase = "wx5A9Vqh12PYo11y";
        #region Private Variables
        static readonly UserSettings instance = new UserSettings();
        private SettingsXML xml = new SettingsXML(SettingsFileName);
        #endregion

        #region Constructor
        /// <summary>
        /// UserSettings Constructor. This is private as the whole class is designed as a singleton
        /// This way we can only ever have one set of settings to work with across the different forms.
        /// </summary>
        static UserSettings(){
        }

        UserSettings() { }

        /// <summary>
        /// Contains the single Instance of the UserSetting.
        /// </summary>
        public static UserSettings Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        /// <summary>
        /// Value containing an internal Passphrase for en-/decryption
        /// </summary>
        public string PassPhrase
        {
            get { return internalPassPhrase; }
        }
        
        /// <summary>
        /// Sets/Gets the amount of time for the statusbar updates to last
        /// </summary>
        /// <value name="StatusTimeout">Int</value>
        public int StatusTimeout
        {
            get { return xml.GetSetting("General/StatusTimeout",5); }
            set { xml.PutSetting("General/StatusTimeout", value); }
        }

        /// <summary>
        /// Whether the application saves its settings during exit
        /// </summary>
        /// <value name="SaveOnExit">Boolean</value>
        public bool SaveOnExit
        {
            get { return xml.GetSetting("General/SaveOnExit",true); }
            set { xml.PutSetting("General/SaveOnExit", value); }
        }

        /// <summary>
        /// Whether the Application starts with a Splash Screen or not
        /// </summary>
        /// <value name="ShowSplash">Boolean</value>
        public bool ShowSplash
        {
            get { return xml.GetSetting("General/ShowSplash", true); }
            set { xml.PutSetting("General/ShowSplash", value); }
        }
        /// <summary>
        /// This specifies the HOST the API is remotely present
        /// </summary>
        /// <value name="ApiHost">String</value>
        public string ApiHost
        {
            get { return xml.GetSetting("Connection/Host",""); }
            set { xml.PutSetting("Connection/Host", value); }
        }

        /// <summary>
        /// The Username used for the API connection
        /// </summary>
        public string ApiUser
        {
            get { return xml.GetSetting("Connection/User", ""); }
            set { xml.PutSetting("Connection/User", value); }
        }

        /// <summary>
        /// The password for the API Connection
        /// </summary>
        public string ApiPass
        {
            get { return xml.GetSetting("Connection/Pass", ""); }
            set { xml.PutSetting("Connection/Pass", value); }
        }
    }
}
