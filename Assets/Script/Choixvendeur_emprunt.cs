using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class Choixvendeur_emprunt : MonoBehaviour
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
        Video.GetComponent<VideoPlayer>().clip = videoClips[0];
        Video.GetComponent<VideoPlayer>().isLooping = true;


    }
    IEnumerator Merci_aurevoir()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[1];
        yield return new WaitForSeconds(3);
        StartCoroutine(enddialogue());
        Curseur.SetActive(true);
        IntdialogueUI.SetActive(true);
    }
    IEnumerator hein_aurevoir()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[2];
        yield return new WaitForSeconds(3);
        StartCoroutine(enddialogue());
        Curseur.SetActive(true);
        IntdialogueUI.SetActive(true);
    }
    IEnumerator sans_cartebiblio()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[4];
        yield return new WaitForSeconds(3);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }

    IEnumerator carte_banquaire_biblio()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[14];
        yield return new WaitForSeconds(4);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }


    IEnumerator adhérent_toilette()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[5];
        yield return new WaitForSeconds(5);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }

    IEnumerator Pas_au_bon_endroit()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[6];
        yield return new WaitForSeconds(4);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);
    }

    IEnumerator emprunt_livre()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[13];
        yield return new WaitForSeconds(9);
        StartCoroutine(enddialogue());
        Curseur.SetActive(true);
        IntdialogueUI.SetActive(true);

    }

    IEnumerator rendre_avant_nouveau()
    {
        ChoiceMade = -1;
        Panel_Bouton.SetActive(false);
        Video.GetComponent<VideoPlayer>().clip = videoClips[8];
        yield return new WaitForSeconds(5);
        Panel_Bouton.SetActive(true);
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
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Je n'ai pas ma carte bancaire..."; //choix 4
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Oui, la voici "; //choix 5
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Non, je l'ai oublié...";// choix 6
        Video.GetComponent<VideoPlayer>().clip = videoClips[9];
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
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Non, je ne l'ai pas";// choix 7 = hein aurevoir
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Je voudrais emprunter un autre livre";//choix 8
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Bien sûr, le voilà!"; //choix 9
        
        Video.GetComponent<VideoPlayer>().clip = videoClips[10];

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
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Bonjour, vous allez bien?";//choix 7
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Mon livre est vert";// choix 7
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Une prochaine fois alors, bonne journée";//choix 10
        Video.GetComponent<VideoPlayer>().clip = videoClips[11];
        yield return new WaitForSeconds(4);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);

    }

    IEnumerator phase4()
    {
        ChoiceMade = -1;
        Phase = 4;
        Panel_Bouton.SetActive(false);
        Choix1.SetActive(true);
        Choix2.SetActive(true);
        Choix3.SetActive(true);
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Rien merci, bonne journée";// choix 10
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Je voudrais rendre un livre";// choix 7
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Je souhaiterai emprunter un nouveau livre";//choix 11
        Video.GetComponent<VideoPlayer>().clip = videoClips[12];
        yield return new WaitForSeconds(7);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);

    }

    IEnumerator phase5()// pouvez vous me donner le livre que vous avez emprunter
    {
        ChoiceMade = -1;
        Phase = 5;
        Panel_Bouton.SetActive(false);
        Choix1.SetActive(true);
        Choix2.SetActive(true);
        Choix3.SetActive(true);
        TextBouton1.GetComponent<TextMeshProUGUI>().text = " Oui, voici";// choix 12
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Je ne veux pas emprunter de livre finalement, bonne journée "; // choix 10
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Bonjour, vous allez bien"; // choix 7
        Video.GetComponent<VideoPlayer>().clip = videoClips[7];
        yield return new WaitForSeconds(4);
        Panel_Bouton.SetActive(true);
        IntdialogueUI.SetActive(true);

    }


    void Start()
    {
        TextBouton1.GetComponent<TextMeshProUGUI>().text = "Je voudrais un sandwich"; //choix 1
        TextBouton2.GetComponent<TextMeshProUGUI>().text = "Pouvez-vous me dire ou se trouvent les toilettes?";// choix 2
        TextBouton3.GetComponent<TextMeshProUGUI>().text = "Je voudrais rendre un livre";// choix 3



    }

    public void ChoiceOption1()
    {

        if (Phase == 0)
        {
            ChoiceMade = 1;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Vous n'êtes pas au bon endroit  (choisissez une autre réponse)"; //ok
            Choix1.SetActive(false);

        }
        if (Phase == 1)
        {
            ChoiceMade = 4;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Je ne vous ai pas demandé votre carte banquaire mais votre carte de bibliothèque s'il vous plait. (choisissez une autre réponse) "; //ok
            Choix1.SetActive(false);

        }
        if (Phase == 2)
        {
            ChoiceMade = 7;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Désolé, je n'ai pas bien compris... Aurevoir...."; //ok

        }
        if (Phase == 3)
        {
            ChoiceMade = 7;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Désolé, je n'ai pas bien compris... Aurevoir... "; //ok

        }
        if (Phase == 4)
        {
            ChoiceMade = 10;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Merci, bonne journée ";

        }
        if (Phase == 5)
        {
            ChoiceMade = 12;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Deux, petite seconde... C'est bon vous pouvez y aller, bonne journée ! ";

        }
    }
    public void ChoiceOption2()
    {
        if (Phase == 0)
        {
            ChoiceMade = 2;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = "  Les toilettes sont réservé au personnel de la bibliothèque vous ne pouvez donc pas y aller, je suis désolé (choisissez une autre réponse)";//ok
            Choix2.SetActive(false);
        }
        if (Phase == 1)
        {
            ChoiceMade = 5;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = "Très bien, avez vous le livre en question s'il vous plait?"; //ok
        }
        if (Phase == 2)
        {
            ChoiceMade = 8;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Il faut d'abord rendre le livre avant d'en prendre un nouveau "; //ok
            Choix2.SetActive(false);
        }
        if (Phase == 3)
        {
            ChoiceMade = 7;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Désolé, je n'ai pas bien compris... Aurevoir... "; //ok
        }
        if (Phase == 4)
        {
            ChoiceMade = 7;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Désolé, je n'ai pas bien compris... Aurevoir... ";

        }
        if (Phase == 5)
        {
            ChoiceMade = 10;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Merci, bonne journée ";

        }

    }
    public void ChoiceOption3()
    {
        if (Phase == 0)
        {
            ChoiceMade = 3;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Très bien, avez vous la carte de la bibliothèque s'il vous plait? "; //ok
        }
        if (Phase == 1)
        {
            ChoiceMade = 6;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = "Je suis désolé mais je ne peux pas reprendre le livre... Bonne journée à vous!"; // ok
        }
        if (Phase == 2)
        {
            ChoiceMade = 9;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Que puis je faire d'autre pour vous "; // ok
        }
        if (Phase == 3)
        {
            ChoiceMade = 10;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Merci, Bonne journée à vous! "; //ok
        }
        if (Phase == 4)
        {
            ChoiceMade = 11;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " D'accord donnez moi le livre que vous voulez emprunter! "; //ok

        }
        if (Phase == 5)
        {
            ChoiceMade = 7;
            IntdialogueUI.SetActive(false);
            Panel_Bouton.SetActive(false);
            TextBox.GetComponent<TextMeshProUGUI>().text = " Merci, bonne journée ";

        }


    }



    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade == 1)//sandwich
        {
            StartCoroutine(Pas_au_bon_endroit()); //ok 
            

        }
        if (ChoiceMade == 2)// toilette 
        {
            StartCoroutine(adhérent_toilette()); //ok 

        }
        if (ChoiceMade == 3)// donner carte biblio
        {
            StartCoroutine(phase1());

        }
        if (ChoiceMade == 4) // carte banquaire
        {
            
            StartCoroutine(carte_banquaire_biblio());//ok 

        }
        if (ChoiceMade == 5)//voici carte biblio
        {

            StartCoroutine(phase2()); //ok
            

        }
        if (ChoiceMade == 6)//sans carte de bibliotheque je ne peux pas prendre votre livre
        {
            StartCoroutine(phase3());  //ok

        }

        if (ChoiceMade==7)//hein_aurevoir
        {
     
            StartCoroutine(hein_aurevoir());
            
        }
 
        if (ChoiceMade == 8)//dabord rend livre
        {
   
            StartCoroutine(rendre_avant_nouveau());
            
        }
        if (ChoiceMade == 9)//rend livre que puisje faire d'autre pour vous?
        {
            StartCoroutine(phase4());
            
        }

        if (ChoiceMade == 10) /// une autre fois, bonne journée
        {
            StartCoroutine(Merci_aurevoir());

        }
        if (ChoiceMade == 11)//rend livre que puis je faire d'autre pour vous?
        {
            StartCoroutine(phase5());


        }
        if (ChoiceMade == 12)//rend livre que puis je faire d'autre pour vous?
        {
            StartCoroutine(emprunt_livre());

        }


    }

}
