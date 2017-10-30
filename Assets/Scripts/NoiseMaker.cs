using UnityEngine;
using System.Collections;

public class NoiseMaker : MonoBehaviour
{

    [SerializeField]
    private AudioClip sound;
    [SerializeField]
    private AudioSource source;
    // Use this for initialization

    public enum SoundType
    {
        peg,
        teleporter,
        bar,
        extra_life,
        points,
        bonus,
        end,
    }
    public SoundType boardObject;

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

    public void OnTriggerEnter()
    {
        switch (boardObject)
        {
            case SoundType.bar:
                source.Play();
                break;
            case SoundType.bonus:
                source.Play();
                break;
            case SoundType.extra_life:
                source.Play();
                break;
            case SoundType.points:
                source.Play();
                break;
            case SoundType.teleporter:
                break;
        }

    }

    public void SoundBite()
    {
        source.Play();
    }

}
