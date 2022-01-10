using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Click_dialogue : MonoBehaviour
{
    public GameObject go;
    public GameObject fleche;
    public bool isTalking = false;
    public GameObject IntdialogueUI;
    public GameObject BiblioClicUI;
    public GameObject Panel_Bouton;
    public GameObject Video;
    public GameObject Camera;
    public VideoClip[] videoClips;
    public GameObject Curseur;


    public Transform anglecourrent;
    public Transform nouvelangle;
    float vitesse = 10f;
    int a=0;
   

    void start()
    {
        IntdialogueUI.SetActive(false);
        BiblioClicUI.SetActive(false);
        fleche.SetActive(true);
        isTalking = false;


    }
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (isTalking == false)
            {
                if (hit.transform.gameObject.tag == "Vendeur")
                {
                    BiblioClicUI.SetActive(true);
                    fleche.SetActive(false);

                }

                if (hit.transform.gameObject.tag == "Vendeur" && Input.GetMouseButtonDown(0))
                {
                    isTalking = true;
                    Curseur.SetActive(false);
                    go = hit.transform.gameObject;
                    GetComponent<Camerapourmouvement>().enabled = false;
                    BiblioClicUI.SetActive(false);
                    transform.rotation = Quaternion.Lerp(anglecourrent.rotation, nouvelangle.rotation, Time.time * vitesse);
                    Video.GetComponent<VideoPlayer>().clip = videoClips[0];
                    Video.GetComponent<VideoPlayer>().isLooping = false;
                    StartCoroutine(affichage_bouton());


                }
            }

        }
        else
        {
            BiblioClicUI.SetActive(false);
            fleche.SetActive(true);

        }


    }
    IEnumerator affichage_bouton()
    {
        yield return new WaitForSeconds(3);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
        Camera.GetComponent<Click_dialogue>().enabled = false;
        Curseur.SetActive(false);
        
    }

}
