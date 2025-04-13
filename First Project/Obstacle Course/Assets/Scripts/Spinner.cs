using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xspin = 0.0f;
    [SerializeField] float yspin = 1.0f;
    [SerializeField] float zspin = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        //yspin = Time.deltaTime * yspin;
        transform.Rotate(xspin, yspin, zspin);
    }
}
