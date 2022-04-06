using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportController : MonoBehaviour
{
    //Time Travel
    private bool hasTravel = false;
    private float currentXpos;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeTravelTeleport();
    }
    private void TimeTravelTeleport()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (hasTravel == true)
            {
                player.transform.position = new Vector3(gameObject.transform.position.x - 100, 0, 0);
                Debug.Log("Time Travel Forward Initiated + X coordinate is " + gameObject.transform.position.x);
                hasTravel = false;
            }
            else
            {
                player.transform.position = new Vector3(gameObject.transform.position.x + 100, 0, 0);
                Debug.Log("Time Travel Back Initiated + X coordinate is " + gameObject.transform.position.x);
                hasTravel = true;
            }
        }


    }
}
