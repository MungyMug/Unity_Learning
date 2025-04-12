using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waittime = 2.0f;

    MeshRenderer myMeshRenderer;

    Rigidbody myRigidBody;
    // Over here is the field for tansfrom size
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
    }

    public void timeElapsed()
    {
        Debug.Log("Time passed: " + Time.time);
    }

    public void DropObject()
    {
        if(Time.time >= waittime)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }

    void Update()
    {
        timeElapsed();
        DropObject();
    }
}
