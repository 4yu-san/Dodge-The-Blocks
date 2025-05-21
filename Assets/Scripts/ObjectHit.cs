using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material Crimson_Color;
    void Start()
    {
        Crimson_Color = Resources.Load<Material>("Mats/Hit Color");
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material = Crimson_Color;
            gameObject.tag = "Hit";
        }//Debug.Log("Collision Occured");    
    }
}
