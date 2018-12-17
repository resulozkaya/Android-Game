using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour
{

    public Text winCount;
    public Text lossCount;

    // Use this for initialization
    void Start()
    {
        if (UserAccountManager.IsLoggedIn)
            UserAccountManager.instance.GetData(OnReceivedData);
    }

    void OnReceivedData(string data)
    {
        if (winCount == null || lossCount == null)
            return;

        winCount.text = DataTranslator.DataToWins(data).ToString() + " KILLS";
        lossCount.text = DataTranslator.DataToLosses(data).ToString() + " DEATHS";
    }

}
