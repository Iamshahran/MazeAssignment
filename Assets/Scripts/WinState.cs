using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    public GameObject winStateText;
    // Start is called before the first frame update
    void Start()
    {
        winStateText.SetActive(false);
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if(!winStateText.activeInHierarchy) if(other.gameObject.CompareTag("MainCamera")) winStateText.SetActive(true);

            
    }


}
