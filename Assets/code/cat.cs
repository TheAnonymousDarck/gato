using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat: MonoBehaviour
{
    public Sprite circle;
    public Sprite cross;
    public GameObject win1, win2, win3, win4, win5, win6, win7, win8;
    public AudioSource sonido;
    public AudioClip clip;


    public static int counter = 0;
    int enter = 0;

    static int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0, x8 = 0, x9 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){

        sonido.PlayOneShot(clip);

        Debug.Log(this.name);

        if(counter< 9){
            if(enter == 1){
                string x = this.gameObject.GetComponent<SpriteRenderer>().name;
                int player = 0;

                if (counter % 2 == 0){
                    // circle;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = circle;
                    player = 1;
                }else{
                    // cross
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = cross;
                    player = 2;
                }

                if(x == "1"){ x1 = player; }
                if(x == "2"){ x2 = player; }
                if(x == "3"){ x3 = player; }
                if(x == "4"){ x4 = player; }
                if(x == "5"){ x5 = player; }
                if(x == "6"){ x6 = player; }
                if(x == "7"){ x7 = player; }
                if(x == "8"){ x8 = player; }
                if(x == "9"){ x9 = player; }

                counter++;
            }
            enter++;
        }
        //quien gano
        if(x1 == 1 && x2 == 1 && x3 == 1) {Debug.Log("gano el circulo"); counter = 9; win1.SetActive(true);}
        if(x3 == 1 && x5 == 1 && x7 == 1) {Debug.Log("gano el circulo"); counter = 9; win2.SetActive(true);}
        if(x4 == 1 && x5 == 1 && x6 == 1) {Debug.Log("gano el circulo"); counter = 9; win3.SetActive(true);}
        if(x7 == 1 && x8 == 1 && x9 == 1) {Debug.Log("gano el circulo"); counter = 9; win4.SetActive(true);}
        if(x1 == 1 && x4 == 1 && x7 == 1) {Debug.Log("gano el circulo"); counter = 9; win5.SetActive(true);}
        if(x2 == 1 && x5 == 1 && x8 == 1) {Debug.Log("gano el circulo"); counter = 9; win6.SetActive(true);}
        if(x3 == 1 && x6 == 1 && x9 == 1) {Debug.Log("gano el circulo"); counter = 9; win7.SetActive(true);}
        if(x1 == 1 && x5 == 1 && x9 == 1) {Debug.Log("gano el circulo"); counter = 9; win8.SetActive(true);}


        if(x1 == 2 && x2 == 2 && x3 == 2) {Debug.Log("gano la tacha"); counter = 9; win1.SetActive(true);}
        if(x3 == 2 && x5 == 2 && x7 == 2) {Debug.Log("gano la tacha"); counter = 9; win2.SetActive(true);}
        if(x4 == 2 && x5 == 2 && x6 == 2) {Debug.Log("gano la tacha"); counter = 9; win3.SetActive(true);}
        if(x7 == 2 && x8 == 2 && x9 == 2) {Debug.Log("gano la tacha"); counter = 9; win4.SetActive(true);}
        if(x1 == 2 && x4 == 2 && x7 == 2) {Debug.Log("gano la tacha"); counter = 9; win5.SetActive(true);}
        if(x2 == 2 && x5 == 2 && x8 == 2) {Debug.Log("gano la tacha"); counter = 9; win6.SetActive(true);}
        if(x3 == 2 && x6 == 2 && x9 == 2) {Debug.Log("gano la tacha"); counter = 9; win7.SetActive(true);}
        if(x1 == 2 && x5 == 2 && x9 == 2) {Debug.Log("gano la tacha"); counter = 9; win8.SetActive(true);}
        
    }
}
