using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            ++hits;
            Debug.Log("You've bumped in the thing this many times: " + hits);
        }
    }
}
