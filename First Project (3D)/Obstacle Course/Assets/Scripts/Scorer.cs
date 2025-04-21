using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            hit += 1;
            Debug.Log("You've bump into a thing this many times: " + hit);
        }
    }
}
