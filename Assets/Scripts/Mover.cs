using System.Threading;
using UnityEngine;

public class Mover : MonoBehaviour
{   //Rigidbody rb;
    [SerializeField] private float MoveSpeed = 5f;
    //private bool goingForward = true;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        MovePlayer();
    }     

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal")* Time.deltaTime * MoveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, yValue, zValue); 
         /*rb.AddForce(transform.forward * zValue * MoveSpeed);
         rb.AddTorque(transform.right * xValue * MoveSpeed); */
    }
}
