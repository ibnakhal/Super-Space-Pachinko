using UnityEngine;
using System.Collections;

public class AnimPlayer : MonoBehaviour {

    [SerializeField]
    private Animation anim;
    [SerializeField]
    private AnimationClip animClip;

	// Use this for initialization
	void Start () {
        anim.clip = animClip;
        anim.Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}


	//----------------------------------
	//Private functions
	//----------------------------------

	//----------------------------------
	//Public functions
	//----------------------------------

}
