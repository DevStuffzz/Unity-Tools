using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//includes sway using q and e keys
public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 offset = Vector3.zero;
        if (Input.GetKey(KeyCode.E))
        {
            offset += Vector3.right / 2;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            offset += Vector3.left / 2;
        }
        if(offset == Vector3.zero)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 3.31f, -10f), speed);
        }
        transform.position += offset;
    }
}
