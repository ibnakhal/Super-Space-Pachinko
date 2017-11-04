using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCatcher : MonoBehaviour {
    public GameObject master;
	// Use this for initialization
	void Start () {
		
	}
	
    public void OnTriggerEnter(Collider Other)
    {
        Debug.Log("I'm Entered");
        if (Other.gameObject == master)
        {
            Debug.Log("Swith!");
            Other.GetComponent<Shift>().Switcheroo();
        }
    }
}
