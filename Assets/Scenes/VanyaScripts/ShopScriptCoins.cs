using UnityEngine;

public class ShopScriptCoin22 : MonoBehaviour
{
    public int coins;
    public int coinsForGame;

    

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins", 0);
        coinsForGame = PlayerPrefs.GetInt("coinsForGame", 0);
    }

}
