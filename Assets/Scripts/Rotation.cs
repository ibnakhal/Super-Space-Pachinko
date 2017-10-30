using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3 Axis;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Axis * Time.deltaTime * speed);
	}
}
