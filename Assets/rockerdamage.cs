using UnityEngine;

public class rockerdamage : MonoBehaviour
{
    float damage;
    public GameObject GameObject;
    public void SetTower(RocketScript rocketScript)
    {
        damage = rocketScript.Damage;

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(GameObject, 2f);
    }
}
