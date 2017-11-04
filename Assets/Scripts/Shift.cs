using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shift : MonoBehaviour {

    public float speed;
    public Vector3 dir;
	// Use this for initialization
	void Start () {
	}


    public void Update()
    {
        this.transform.Translate(dir * Time.deltaTime * speed);

    }

    public void Switcheroo()
    {
        dir = -dir;
    }

}
