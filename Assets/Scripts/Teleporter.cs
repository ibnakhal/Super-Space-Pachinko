using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {


    [SerializeField]
    private Transform Target;
    [SerializeField]
    private float teleTime;
    [SerializeField]
    public NoiseMaker sound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter (Collider Other)
    {
        StartCoroutine(Tele(Other));
    }
    public IEnumerator Tele(Collider Other)
    {
        yield return new WaitForSeconds(teleTime);
        Other.gameObject.transform.position = Target.position;
        sound.SoundBite();
    }
}
