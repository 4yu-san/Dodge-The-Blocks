using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xrot = 0f;
    [SerializeField] float yrot = 0f;
    [SerializeField] float zrot = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xrot, yrot, zrot);
    }
}
