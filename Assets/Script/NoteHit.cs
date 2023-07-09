using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NoteHit : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject hitEffect,goodEffect,PerfectEff,missEff;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed) 
            {
                gameObject.SetActive(false);

                if (Mathf.Abs(transform.position.y) > 0.3)  //若範圍在設定box collider 距離上下大於0.6f的距離判定miss
                {
                    GameManager.instance.NoteMiss();
                }else if (Mathf.Abs(transform.position.y) > 0.1) //0.6 ~ 0.3f 內 good
                {
                    GameManager.instance.GoodHit(); //0.3f perfect
                }
                else
                {
                    GameManager.instance.PerfectHit();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && gameObject.activeSelf)
        {
            canBePressed = false;
            gameObject.SetActive(false);
            GameManager.instance.NoteMiss();
        }
    }
}
