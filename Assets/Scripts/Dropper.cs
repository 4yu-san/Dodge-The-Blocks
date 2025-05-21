using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float wait_time = 3f;
    
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Drop();
    }

    void Drop()
    {
        if (Time.time > wait_time)
        {
            //Debug.Log("object boutta drop");
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }    
    }
}
