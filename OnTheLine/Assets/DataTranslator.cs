using UnityEngine;
using System;

public class DataTranslator : MonoBehaviour
{

    private static string WINS_SYMBOL = "[KILLS]";
    private static string LOSSES_SYMBOL = "[DEATHS]";

    public static string ValuesToData(int kills, int deaths)
    {
        return WINS_SYMBOL + kills + "/" + LOSSES_SYMBOL + deaths;
    }

    public static int DataToWins(string data)
    {
        return int.Parse(DataToValue(data, WINS_SYMBOL));
    }

    public static int DataToLosses(string data)
    {
        return int.Parse(DataToValue(data, LOSSES_SYMBOL));
    }

    private static string DataToValue(string data, string symbol)
    {
        string[] pieces = data.Split('/');
        foreach (string piece in pieces)
        {
            if (piece.StartsWith(symbol))
            {
                return piece.Substring(symbol.Length);
            }
        }

        Debug.LogError(symbol + " not found in " + data);
        return "";
    }

}
