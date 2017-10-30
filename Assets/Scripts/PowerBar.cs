using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour {
    public Manager dataSource;

    public int thresh1;
    public int thresh2;
    public int thresh3;
    public int thresh4;
    public int thresh5;
    public int thresh6;

    public Image bar1;
    public Image bar2;
    public Image bar3;
    public Image bar4;
    public Image bar5;
    public Image bar6;


    // Update is called once per frame
    void Update ()
    {
        if (dataSource.fireForceMultiplier > thresh1)
        {
            bar1.gameObject.SetActive(true);

            if (dataSource.fireForceMultiplier > thresh2)
            {
                bar2.gameObject.SetActive(true);

                if (dataSource.fireForceMultiplier > thresh3)
                {
                    bar3.gameObject.SetActive(true);

                    if (dataSource.fireForceMultiplier > thresh4)
                    {
                        bar4.gameObject.SetActive(true);

                        if (dataSource.fireForceMultiplier > thresh5)
                        {
                            bar5.gameObject.SetActive(true);

                            if (dataSource.fireForceMultiplier > thresh6)
                            {
                                bar6.gameObject.SetActive(true);
                            }
                            else
                            {
                                bar6.gameObject.SetActive(false);
                            }
                        }
                        else
                        {
                            bar5.gameObject.SetActive(false);
                        }
                    }
                    else
                    {
                        bar4.gameObject.SetActive(false);
                    }
                }
                else
                {
                    bar3.gameObject.SetActive(false);
                }
            }
            else
            {
                bar2.gameObject.SetActive(false);
            }
        }
        else
        {
            bar1.gameObject.SetActive(false);

        }


    }
}
