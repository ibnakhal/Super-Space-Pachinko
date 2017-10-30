using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Manager : MonoBehaviour {
    [SerializeField]
    private string levelName;
    [SerializeField]
    private bool BonusShots;
    [SerializeField]
    public int Balls;
    [SerializeField]
    private bool BonusTriggered;
    [SerializeField]
    private Transform spaceShip;
    [SerializeField]
    private Transform spawnLocation;
    [SerializeField]
    public int bonusLimit;
    [SerializeField]
    private int bonusUIInt;
    [SerializeField]
    private int hiddenBalls;
    [SerializeField]
    private float bonusSpawnTime;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject bonusBall;
    [SerializeField]
    private float shotCooldown;
    [SerializeField]
    private bool fired;
    [SerializeField]
    public float fireForceMultiplier;
    [SerializeField]
    private float forceMax;
    [SerializeField]
    private float forceMin;
    [SerializeField]
    private float forceChange;
    [SerializeField]
    private float forceChangeTime;
    [SerializeField]
    private int total;
    [SerializeField]
    private AudioSource shipSource;
    [SerializeField]
    private Text ballText;
    [SerializeField]
    private Text bonusText;
    [SerializeField]
    private Text pointText;
    [SerializeField]
    private Text endText;

    [SerializeField]
    private GameObject cig;
    [SerializeField]
    private Transform cigSpawn;
    [SerializeField]
    private int threshold;
    [SerializeField]
    private int levelModifier;
    [SerializeField]
    private bool ending = true;


    [SerializeField]
    private PlayerPref pPref;
    // Use this for initialization
    void Start () {
        StartCoroutine(Up());
        pPref = GameObject.FindGameObjectWithTag("Background").GetComponent<PlayerPref>();

    }
	
	// Update is called once per frame
	void Update () {
        if (bonusLimit <= 0 && Balls <= 0 && GameObject.Find("ball(Clone)")==null && GameObject.Find("Meteor(Clone)") == null && GameObject.Find("BonusBall(Clone)") == null && ending)
        {
            ending = false;
            Debug.Log("Game Over");
            endText.gameObject.SetActive(true);
            StartCoroutine(Endgame());
        }
        if(Input.GetMouseButtonDown(0) && !fired && Balls > 0)
        {
            Debug.Log("ShotsFired");
            StartCoroutine(Fire());
        }
        if(bonusLimit<0)
        {
            bonusLimit = 0;
        }


        ballText.text = ( Balls.ToString());
        bonusText.text = (bonusLimit.ToString());
        pointText.text = ("Points: " + total);

    }

    public IEnumerator Endgame()
    {
        pPref.LeaderBoardUpdate(total, levelName);
        pPref.LeaderBoardSave();
        yield return new WaitForSeconds(5);
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        Application.LoadLevel(1);
    }

    public IEnumerator LetLoose()
    {
        shipSource.Play();
        yield return new WaitForSeconds(shipSource.clip.length - 2.5f);
        for(int x= 0; x< bonusLimit; bonusLimit--)
        {
            yield return new WaitForSeconds(bonusSpawnTime);
            Instantiate(bonusBall, spaceShip.position, spaceShip.rotation);
        }
            BonusShots = true;
    }
    public IEnumerator Flood()
    {
        shipSource.Play();
        yield return new WaitForSeconds(shipSource.clip.length - 2.5f);
        for (int x = 0; x < bonusLimit; bonusLimit--)
        {
            yield return new WaitForSeconds(bonusSpawnTime);
            GameObject clone = Instantiate(bonusBall, spawnLocation.position, spawnLocation.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(Vector3.up * fireForceMultiplier);
            yield return new WaitForSeconds(shotCooldown / 3);
        }
        bonusLimit = 0;
        BonusShots = true;
    }
    public IEnumerator Fire()
    {
        fired = true;
        Balls--;
        GameObject clone = Instantiate(ball, spawnLocation.position, spawnLocation.rotation) as GameObject;
        clone.GetComponent<Rigidbody>().AddForce(Vector3.up * fireForceMultiplier);
        yield return new WaitForSeconds(shotCooldown);
        fired = false;
        Debug.Log("Fire Close Loop");
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


    public void Intake(int points)
    {
        total += points;
        if(total >= threshold)
        {
            Instantiate(cig, cigSpawn.position, cigSpawn.rotation);
            threshold += levelModifier;
        }

    }
    public void Reward(int reward)
    {

        bonusLimit += reward;

    }
    public void Upkeep(int addition)
    {
        Balls+= addition;
    }

    public void Launch()
    {
            BonusShots = false;
            StartCoroutine(LetLoose());
    }
}
