using UnityEngine;
using System.Collections;

public class NoiseMaker : MonoBehaviour
{

    [SerializeField]
    private AudioClip sound;
    [SerializeField]
    private AudioSource source;
    // Use this for initialization
    void Start()
    {
        source = this.gameObject.GetComponent<AudioSource>();
        source.clip = sound;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        source.Play();

    }

    public void OnTriggerEnter(Collider Other)
    {
        source.Play();

    }

}
