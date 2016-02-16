/************************
-------------------------
|*   Pause.cs          *|
|*   Ibrahim Nakhal    *|
|*   Student           *|
|*   AAU Game Design   *|
-------------------------
************************/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour 
{


    [SerializeField]
     public Text txt;
    [SerializeField]
    public string pTxt;
    [SerializeField]
    Camera cM;
    [SerializeField]
    GameObject pL;
    
    public void Start()
    {
         cM = Camera.main;
         pL = GameObject.FindGameObjectWithTag("Player");
         txt.enabled = false;
        AudioListener.pause = false;


    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            print("ESCAPED");
           togglePause();
        }

        if (Input.GetKey(KeyCode.F12))
        {
            Application.Quit();
        }
    }
     

     
     void togglePause()
     {
         if(Time.timeScale == 0f)
         {
             txt.enabled = false;
             Time.timeScale = 1f;
            AudioListener.pause = false;
 


  
         }
         else
         {
             Time.timeScale = 0f;
             txt.text = pTxt;
             txt.enabled = true;
            AudioListener.pause = true;
              
         }
     }
 }

