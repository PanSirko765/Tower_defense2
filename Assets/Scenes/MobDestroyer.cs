using UnityEngine;

public class MobDestroyer : MonoBehaviour
{
    private void OnDestroy()
    {
        MobSpawn.Instanse.SamoRemove(gameObject);
    }
}
