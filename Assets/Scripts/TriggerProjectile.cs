using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectile = new GameObject[5];

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i <= 4; i++)
            {
                if (projectile[i] != null)
                {
                    projectile[i].SetActive(true);
                    Destroy(gameObject);
                }
            }
        }
    }
}
