using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private int total;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Intake(int points)
    {
        total += points;
    }
}
