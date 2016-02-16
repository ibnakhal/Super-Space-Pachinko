using UnityEngine;
using System.Collections;

public class Wait : MonoBehaviour {

    [SerializeField] 
    private AudioClip audioC;
    [SerializeField]
    private AudioSource audioS;
    [SerializeField]
    private int time;
	// Use this for initialization
	void Start () 
    {
        audioS.clip = audioC;
        StartCoroutine(Begin());

	}
	
    public IEnumerator Begin()
    {
        yield return new WaitForSeconds(time);
        audioS.Play();
    }
}
