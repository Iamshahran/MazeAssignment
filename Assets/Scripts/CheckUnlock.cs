using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{
    public GameObject door = null;
    // Start is called before the first frame update
    void Start()
    {
        if(door != null)
        {
            door.SetActive(true);
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key") && door != null)
        {
            door.SetActive(false);
        }
    }


}
