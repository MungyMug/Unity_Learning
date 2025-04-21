using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerpostition = Vector3.zero;

    [SerializeField] float projectileSpeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerpostition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReach();
    }

    void DestroyWhenReach()
    {
        if(transform.position == playerpostition)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerpostition, projectileSpeed * Time.deltaTime);
    }
}
