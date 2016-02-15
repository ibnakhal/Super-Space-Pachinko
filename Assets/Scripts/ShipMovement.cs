using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {
    [SerializeField]
    private Transform pointA;
    [SerializeField]
    private Transform pointB;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float turnSpeed;
    [SerializeField]
    private Vector3 newVector;
    [SerializeField]
    private Vector3 turnVector;
    [SerializeField]
    private Vector3 vectorA;
    [SerializeField]
    private Vector3 vectorB;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()

    {
        this.transform.Translate(newVector * Time.deltaTime * speed);
        this.transform.Rotate(turnVector * Time.deltaTime * turnSpeed);
	}

    public void OnTriggerEnter(Collider Other)
    {
        Debug.Log("Boom");
        if(Other.gameObject == pointA.gameObject)
        {
            newVector = vectorA;
        }
        if (Other.gameObject == pointB.gameObject)
        {
            newVector = vectorB;

        }
    }





}
