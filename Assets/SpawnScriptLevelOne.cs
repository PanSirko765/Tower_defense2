using UnityEngine;

public class SpawnScriptLevelOne : MonoBehaviour
{
    public GameObject game;
    public GameObject start;

    private void Start()
    {
        Instantiate(game, start.transform);
    }
}
