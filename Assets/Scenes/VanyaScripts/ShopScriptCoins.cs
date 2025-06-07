using UnityEngine;

public class ShopScriptCoin22 : MonoBehaviour
{
    public int coins;
    public int coinsForGame;

    public static ShopScriptCoin22 instance;

    private void Awake()
    {
        
        instance = this;
        
        coins = PlayerPrefs.GetInt("coins", 0);
        coins += 100000;
        coinsForGame = PlayerPrefs.GetInt("coinsForGame", 0);
    }

}
