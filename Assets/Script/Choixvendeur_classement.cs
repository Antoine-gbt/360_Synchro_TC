using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class Choixvendeur_classement : MonoBehaviour
{
    public GameObject Curseur;
    public GameObject Camera;
    public GameObject Video;
    public VideoClip[] videoClips;

    public GameObject Panel_Bouton;
    public GameObject IntdialogueUI;
    public GameObject Vendeur;
    public GameObject Classement_livre_canvas;

    public GameObject TextBouton1;
    public GameObject TextBouton2;
    public GameObject TextBouton3;

    public GameObject TextBox;
    public GameObject Choix1;
    public GameObject Choix2;
    public GameObject Choix3;

    public int ChoiceMade = 0;
    public int Phase = 0;


    IEnumerator enddialogue()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        yield return new WaitForSeconds(3);
        IntdialogueUI.SetActive(false);
        Vendeur.SetActive(false);
        Camera.GetComponent<Click_dialogue>().enabled = true;
        Camera.GetComponent<Camerapourmouvement>().enabled = true;
        Video.GetComponent<VideoPlayer>().clip = videoClips[10];
        Video.GetComponent<VideoPlayer>().isLooping = true;


    }
    IEnumerator Merci_aurevoir()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[8];
        yield return new WaitForSeconds(3);
        StartCoroutine(enddialogue());
        Curseur.SetActive(true);
        IntdialogueUI.SetActive(true);
    }
    IEnumerator hein_aurevoir()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[6];
        yield return new WaitForSeconds(3);
        StartCoroutine(enddialogue());
        Curseur.SetActive(true);
        IntdialogueUI.SetActive(true);
    }

    IEnumerator Classement_livre()
    {
        ChoiceMade = -1;
        IntdialogueUI.SetActive(false);
        Classement_livre_canvas.SetActive(true);
        yield return new WaitForSeconds(3);
    }

    IEnumerator adhérent_toilette()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[1];
        yield return new WaitForSeconds(5);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }

    public void ChoiceOption1()
    {

        if (Phase == 0)
        {
            ChoiceMade = 1;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Les toilettes sont réservé au personnel de la bibliothèque vous ne pouvez donc pas y aller, je suis désolé (choisissez une autre réponse)";


        }

    }
    public void ChoiceOption2()
    {
        if (Phase == 0)
        {
            ChoiceMade = 2;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Très bien avez vous votre carte de la bibliothèque s'il vous plait?";
        }
    }
    public void ChoiceOption3()
    {
        if (Phase == 0)
        {
            ChoiceMade = 3;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Malheureusement, avant d'emprunter un nouveau livre, il faut que vous ramenier celui que vous avez chez vous, s'il vous plait.(choisissez une autre réponse)";
        }
    }


    void Start()
    {
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Pouvez-vous me dire ou se trouvent les toilettes?";
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Je souhaiterais ranger des livres ";
        TextBouton3.GetComponent<TextMeshProUGUI>().text = " Je veux emprunter un livre";

    }
    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade == 1)//toilette
        {
            Choix1.SetActive(false);
            StartCoroutine(adhérent_toilette());


        }
        if (ChoiceMade == 2)// rendre un livre 
        {

            StartCoroutine(Classement_livre());

        }
        if (ChoiceMade == 3)// impossible de prendre un livre sans donner l'ancien
        {
            Choix3.SetActive(false);
            StartCoroutine(hein_aurevoir());

        }
    }

}
