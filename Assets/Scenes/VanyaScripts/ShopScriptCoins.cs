using UnityEngine;

public class ShopScriptCoin : MonoBehaviour
{
    public int coins;
    public int coinsForGame;

    public static ShopScriptCoin instance;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins", 0);
        coinsForGame = PlayerPrefs.GetInt("coinsForGame", 0);
    }

}
