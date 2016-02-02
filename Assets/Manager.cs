using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    [SerializeField]
    private bool BonusShots;
    [SerializeField]
    private int Balls;
    [SerializeField]
    private bool BonusTriggered;
    [SerializeField]
    private Transform spaceShip;
    [SerializeField]
    private Transform spawnLocation;
    [SerializeField]
    private int bonusLimit;
    [SerializeField]
    private float bonusSpawnTime;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private float shotCooldown;
    [SerializeField]
    private bool fired;
    [SerializeField]
    private float fireForceMultiplier;
    [SerializeField]
    private float forceMax;
    [SerializeField]
    private float forceMin;
    [SerializeField]
    private float forceChange;
    [SerializeField]
    private float forceChangeTime;
        
	// Use this for initialization
	void Start () {
        StartCoroutine(Up());
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Jump") && !fired)
        {
            Fire();
        }
        if (Input.GetButtonDown("Fire1") && BonusShots)
        {
            StartCoroutine(LetLoose());
        }

        



    }



    public IEnumerator LetLoose()
    {
        for(int x= 0; x< bonusLimit; x++)
        {
            yield return new WaitForSeconds(bonusSpawnTime);
            Instantiate(ball, spaceShip.position, spaceShip.rotation);
        }
    }
    public IEnumerator Fire()
    {
        fired = true;
        GameObject clone = Instantiate(ball, spawnLocation.position, spawnLocation.rotation) as GameObject;
        clone.GetComponent<Rigidbody>().AddForce(Vector3.up * fireForceMultiplier);
        yield return new WaitForSeconds(shotCooldown);
        fired = false;
    }

    public void ShipsActive()
    {
        BonusShots = true;
    }



    public IEnumerator Up()
    {
        while(fireForceMultiplier<forceMax)
        {
            yield return new WaitForSeconds(forceChangeTime);
            fireForceMultiplier += forceChange;
            if(fireForceMultiplier >= forceMax)
            {
                StartCoroutine(Down());
            }
        }

    }
    public IEnumerator Down()
    {
        while(fireForceMultiplier>forceMin)
        {
            yield return new WaitForSeconds(forceChangeTime);
            fireForceMultiplier -= forceChange;
            if (fireForceMultiplier <= forceMin)
            {
                StartCoroutine(Up());
            }
        }
    }

}
