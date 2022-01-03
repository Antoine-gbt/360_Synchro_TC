using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class Choixvendeur : MonoBehaviour
{
    public GameObject Curseur;
    public GameObject Camera;
    public GameObject Video;
    public VideoClip[] videoClips;

    public GameObject Panel_Bouton;
    public GameObject IntdialogueUI;
    public GameObject Vendeur;

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
    IEnumerator sans_cartebiblio()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[10];
        yield return new WaitForSeconds(3);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }
   /* IEnumerator rend_dabord()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[7];
        yield return new WaitForSeconds(3);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }*/
    IEnumerator carte_banquaire_biblio()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[3];
        yield return new WaitForSeconds(4);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
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
    IEnumerator Livre_Merci_aurevoir()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[9];
        yield return new WaitForSeconds(6);
        StartCoroutine(enddialogue());
        Curseur.SetActive(true);
        IntdialogueUI.SetActive(true);
    }

    IEnumerator rendre_avant_nouveau()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[2];
        yield return new WaitForSeconds(5);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }

    IEnumerator pas_vous_aider()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[11];
        yield return new WaitForSeconds(3);
        StartCoroutine(enddialogue());
        Curseur.SetActive(true);
        IntdialogueUI.SetActive(true);

    }

    IEnumerator phase1()
    {
        ChoiceMade = -1;
        Phase = 1;
        Panel_Bouton.SetActive(false);
        Choix1.SetActive(true);
        Choix2.SetActive(true);
        Choix3.SetActive(true);
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Oui, Voici";
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Je n'ai pas ma carte bancaire...";
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Non, je l'ai oublié...";
        Video.GetComponent<VideoPlayer>().clip = videoClips[0];
        yield return new WaitForSeconds(4);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);


    }
    IEnumerator phase2()
    {
        ChoiceMade = -1;

        Phase = 2;
        Panel_Bouton.SetActive(false);
        Choix1.SetActive(true);
        Choix2.SetActive(true);
        Choix3.SetActive(true);
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Oui, bien sûr";
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Je voudrais emprunter un autre livre";
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Non, je ne l'ai pas";
        Video.GetComponent<VideoPlayer>().clip = videoClips[5];

        yield return new WaitForSeconds(9);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);


    }

    IEnumerator phase3()
    {
        ChoiceMade = -1;
        Phase = 3;
        Panel_Bouton.SetActive(false);
        Choix1.SetActive(true);
        Choix2.SetActive(true);
        Choix3.SetActive(true);
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Bonjour, vous allez bien?";
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Mon livre est vert";
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Une prochaine fois alors, bonne journée";
        Video.GetComponent<VideoPlayer>().clip = videoClips[4];
        yield return new WaitForSeconds(4);
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
        if (Phase == 1)
        {
            ChoiceMade = 4;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Très bien, avez vous le livre en question s'il vous plait? ";
  

        }
        if (Phase == 2)
        {
            ChoiceMade = 10;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Très bien, aurevoir";

        }
        if (Phase == 3)
        {
            ChoiceMade = 9;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Désolé, je n'ai pas bien compris... Aurevoir... ";

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
        if (Phase == 1)
        {
            ChoiceMade = 5;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = "Je ne vous ai pas demandé votre carte banquaire mais votre carte de bibliothèque s'il vous plait. (choisissez une autre réponse)";
        }
        if (Phase == 2)
        {
            ChoiceMade = 7;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Malheureusement, avant d'emprunter un nouveau livre, il faut que vous ramenier celui que vous avez chez vous, s'il vous plait.(choisissez une autre réponse)";
        }
        if (Phase == 3)
        {
            ChoiceMade = 9;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Désolé, je n'ai pas bien compris... Aurevoir... ";
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
        if (Phase == 1)
        {
            ChoiceMade = 6;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = "Je suis désolé mais je ne peux pas reprendre le livre... Bonne journée à vous!";
        }
        if (Phase == 2)
        {
            ChoiceMade = 11;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Dans ce cas je ne peux pas vous aider ";
        }
        if (Phase == 3)
        {
            ChoiceMade = 8;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Merci, Bonne journée à vous! ";
        }

    }


    void Start()
    {
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Pouvez-vous me dire ou se trouvent les toilettes?";
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Je voudrais rendre un livre";
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Je voudrais emprunter un livre";

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

            StartCoroutine(phase1());

        }
        if (ChoiceMade == 3)// impossible de prendre un livre sans donner l'ancien
        {
            Choix3.SetActive(false);
            StartCoroutine(rendre_avant_nouveau());

        }
        if (ChoiceMade == 4) // avez vous le livre?
        {
            StartCoroutine(phase2());

        }
        if (ChoiceMade == 5)//jamais parler de carte banquaire
        {
            Choix2.SetActive(false);
            StartCoroutine(carte_banquaire_biblio());
            

        }
        if (ChoiceMade == 6)//sans carte de bibliotheque je ne peux pas prendre votre livre
        {
            StartCoroutine(phase3()); 

        }

        if (ChoiceMade==7)//rendez moi votre livre d'abord
        {
            Choix2.SetActive(false);
            StartCoroutine(rendre_avant_nouveau());
            
        }
 
        if (ChoiceMade == 8)//merci_aurevoir
        {
            StartCoroutine(Merci_aurevoir());
            
        }
        if (ChoiceMade == 9)//Hein aurevoir
        {
            StartCoroutine(hein_aurevoir());
            
        }

        if (ChoiceMade == 10) /// (rend livre) Merci, bonne journée
        {
            StartCoroutine(Livre_Merci_aurevoir());

        }
        if (ChoiceMade == 11) /// pas vous aider
        {
            StartCoroutine(pas_vous_aider());

        }


    }

}
