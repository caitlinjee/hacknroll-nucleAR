using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

namespace Com.NucleAr.MapAr
{
    class LobbyTopPanel : MonoBehaviour
    {
        private readonly string connectionStatusMessage = "    Connection Status: ";
        [Header("UI References")]
        public Text ConnectionStatusText;
        public void Update()
        {
            ConnectionStatusText.text = connectionStatusMessage + PhotonNetwork.NetworkClientState;
        }
    }
}
