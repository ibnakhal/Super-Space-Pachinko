using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    [SerializeField]
    private float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.right * Time.deltaTime * speed);
	}
}
