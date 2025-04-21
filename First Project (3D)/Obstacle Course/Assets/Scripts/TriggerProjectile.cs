using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectile;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            for (int i = 0; i < projectile.Length; i++)
            {
                if (projectile[i] != null)
                {
                    projectile[i].SetActive(true);
                }
            }
        }
    }
}
