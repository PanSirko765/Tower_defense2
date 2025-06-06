using UnityEngine;

public class ShopScriptCoin22 : MonoBehaviour
{
    public int coins;
    public int coinsForGame;

    public static ShopScriptCoin22 instance;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins", 0);
        coinsForGame = PlayerPrefs.GetInt("coinsForGame", 0);
    }

}
