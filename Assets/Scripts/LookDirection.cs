using UnityEngine;
using System.Collections;

public class LookDirection : MonoBehaviour {
    [SerializeField]
    private Vector3 vector;
    void Update () {
        this.transform.LookAt(vector);
	}
}
