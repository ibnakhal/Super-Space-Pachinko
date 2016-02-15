using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {


    [SerializeField]
    private Transform Target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter (Collider Other)
    {
        Other.gameObject.transform.position = Target.position;
    }
}
