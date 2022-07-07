using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureThings : MonoBehaviour
{
    RaycastHit hit;
    public GameObject DoorPicInShoot;
    public GameObject DoorPicInProjection;
    public GameObject DoorCapable;


    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit,50))
        {
            if(hit.collider.tag == "AbleToCapture" && hit.collider.name == "DoorOpen2")
            {
                DoorCapable.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    DoorPicInShoot.SetActive(true);
                    DoorPicInProjection.SetActive(true);
                }
            }
            else
            {
                DoorCapable.SetActive(false);
            }
        }
    }
}