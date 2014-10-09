using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JokerAPI;

namespace JAMLib
{
    public class Connect
    {

        private string host;
        private string user;
        private string pass;
        private int status;
        private bool connected = false;
        private const string internalPassPhrase = "wx5A9Vqh12PYo11y";
        [Flags] private enum ConnectionState { stateConnected=0, stateInvalidHost=1 << 0, stateInvalidUser=1 << 1, stateInvalidPass=1 << 2, stateInvalid=1 << 3 };

        /// <summary>
        /// Constructor for connection via JAMLib
        /// </summary>
        /// <param name="cHost">Host to connect to</param>
        /// <param name="cUser">User to connect with</param>
        /// <param name="cPass">Password for connection</param>
        public Connect(string cHost = "", string cUser = "", string cPass = "")
        {
            host = cHost;
            user = cUser;
            pass = cPass;
            if (host == "" || user == "" || pass == "")
            {
                connected = false;
                if ( host == "")
                { status = (int)ConnectionState.stateInvalidHost; }
                else if ( user=="")
                { status = (int)ConnectionState.stateInvalidUser; }
                else if ( pass == "")
                { status = (int)ConnectionState.stateInvalidPass; }
                else { status = (int)ConnectionState.stateInvalid;  }
            }
            else
            {
                connected = true;
                status = (int)ConnectionState.stateConnected;
            }
        }

        /// <summary>
        /// Returns connection state (true/false)
        /// </summary>
        public bool isConnected
        {
            get { return connected; }
        }

        public int connectionState
        {
            get { return status; }
        }

        /// <summary>
        /// Value containing an internal Passphrase for en-/decryption
        /// </summary>
        public string PassPhrase
        {
            get { return internalPassPhrase; }
        }


    }
}
