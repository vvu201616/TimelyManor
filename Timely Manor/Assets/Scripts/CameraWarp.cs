using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraWarp : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // vcam.OnTargetObjectWarped(player.transform, player.transform.position);
    }
}
