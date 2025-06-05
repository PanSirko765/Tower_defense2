using UnityEngine;

public class ScriptForMinigun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShopScriptCoin.instance.coinsForGame += 25;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
