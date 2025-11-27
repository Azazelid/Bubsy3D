using UnityEngine;
using UnityEngine.Rendering;

public class EnemyHealth : MonoBehaviour
{
    public float salud= 100;

    public void TakeDamage(float damage)
    {
        salud-=damage;
        if (salud < 0)
        {
            Destroy(gameObject);
        }
    }
}
