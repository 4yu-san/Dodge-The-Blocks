using UnityEngine;

public class FlyAtYa : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float Bawl_speed = 1f;
    Vector3 playerPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gameObject.SetActive(false);
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
                player = playerObj.transform;
            else
                Debug.LogWarning("Player not found! Make sure the Player has the tag 'Player'");
        }
    }
    void Start()
    {
        
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //playerPos = player.transform.position;
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Bawl_speed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPos)
            Destroy(gameObject);
    }
}
