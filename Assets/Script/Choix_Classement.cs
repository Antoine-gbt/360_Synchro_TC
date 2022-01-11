using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;


public class Choix_Classement : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Canvas_Classement_Livre;
    public GameObject UIdialogue;
    public GameObject TextBox;
    public GameObject Vendeur;
    

    public GameObject Valider;
    public VideoClip[] videoClips;
    public GameObject Video;


    public GameObject Curseur;

    public GameObject R;
    public GameObject Z;
    public GameObject S;
    public GameObject D;
    public GameObject P;
    public GameObject H;
    public GameObject T;
    public GameObject A;
    public GameObject C;
    public GameObject K;

    public GameObject Position1;
    public GameObject Position2;
    public GameObject Position3;
    public GameObject Position4;
    public GameObject Position5;
    public GameObject Position6;
    public GameObject Position7;
    public GameObject Position8;
    public GameObject Position9;
    public GameObject Position10;

    public Text TextPosition1;
    public Text TextPosition2;
    public Text TextPosition3;
    public Text TextPosition4;
    public Text TextPosition5;
    public Text TextPosition6;
    public Text TextPosition7;
    public Text TextPosition8;
    public Text TextPosition9;
    public Text TextPosition10;
    public Text tentative;

    private bool onclic;
    private int essai;

    private int position_actuelle;
    private GameObject position;
    private Text Textposition;
    private int Choix;
    private bool position_use;
    private bool reussite;



    // Start is called before the first frame update
    void Start()
    {
        Camera.GetComponent<Camerapourmouvement>().enabled = false;
        Camera.GetComponent<Click_dialogue>().enabled = false;
        onclic = false;
        position_use = false;
        Curseur.SetActive(false);
        Position1.SetActive(false);
        Position2.SetActive(false);
        Position3.SetActive(false);
        Position4.SetActive(false);
        Position5.SetActive(false);
        Position6.SetActive(false);
        Position7.SetActive(false);
        Position8.SetActive(false);
        Position9.SetActive(false);
        Position10.SetActive(false);
        Valider.SetActive(false);
        Canvas_Classement_Livre.SetActive(true);
        position_actuelle = 0;
        Choix = 0;
        essai = 0;
        tentative.GetComponent<Text>().text = " Nombre de tentative : 3";
        reussite = false;

    }



    public void verif_position_actuelle()
    {
        if (onclic == true)
        {
            if (position_actuelle == 1)
            {
                position = Position1;
                Textposition = TextPosition1;
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }

            if (position_actuelle == 2)
            {
                position = Position2;
                Textposition = TextPosition2;
                Position1.GetComponent<Button>().enabled = false;
                Position1.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;

            }
            if (position_actuelle == 3)
            {
                position = Position3;
                Textposition = TextPosition3;
                Position2.GetComponent<Button>().enabled = false;
                Position2.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;

            }
            if (position_actuelle == 4)
            {
                position = Position4;
                Textposition = TextPosition4;
                Position3.GetComponent<Button>().enabled = false;
                Position3.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }
            if (position_actuelle == 5)
            {
                position = Position5;
                Textposition = TextPosition5;
                Position4.GetComponent<Button>().enabled = false;
                Position4.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }
            if (position_actuelle == 6)
            {
                position = Position6;
                Textposition = TextPosition6;
                Position5.GetComponent<Button>().enabled = false;
                Position5.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }
            if (position_actuelle == 7)
            {
                position = Position7;
                Textposition = TextPosition7;
                Position6.GetComponent<Button>().enabled = false;
                Position6.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }
            if (position_actuelle == 8)
            {
                position = Position8;
                Textposition = TextPosition8;
                Position7.GetComponent<Button>().enabled = false;
                Position7.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }
            if (position_actuelle == 9)
            {
                position = Position9;
                Textposition = TextPosition9;
                Position8.GetComponent<Button>().enabled = false;
                Position8.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }
            if (position_actuelle == 10)
            {
                position = Position10;
                Textposition = TextPosition10;
                Position9.GetComponent<Button>().enabled = false;
                Position9.GetComponent<Image>().color = new Color32(172, 172, 172, 255);
                position.GetComponent<Button>().enabled = true;
                position.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                onclic = false;
            }
        }
    }

    public void Choix_R()
    {
        onclic = true;
        R.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "R";
        position.SetActive(true);
        //  onclic = false;


    }
    public void Choix_Z()
    {
        onclic = true;
        Z.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "Z";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_S()
    {
        onclic = true;
        S.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "S";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_D()
    {
        onclic = true;
        D.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "D";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_P()
    {
        onclic = true;
        P.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "P";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_H()
    {
        onclic = true;
        H.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "H";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_T()
    {
        onclic = true;
        T.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "T";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_A()
    {
        onclic = true;
        A.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "A";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_C()
    {
        onclic = true;
        C.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "C";
        position.SetActive(true);
        onclic = false;
    }
    public void Choix_K()
    {
        onclic = true;
        K.SetActive(false);
        position_actuelle = position_actuelle + 1;
        verif_position_actuelle();
        Textposition.GetComponent<Text>().text = "K";
        position.SetActive(true);
        //  onclic = false;
    }

    public void validation()
    {
        if (position_actuelle == 10)
        {
            Valider.SetActive(true);
        }
        else
        {
            Valider.SetActive(false);
        }
    }

    public void fin_classement()
    {

        if (TextPosition1.text == "A" && TextPosition2.text == "C" && TextPosition3.text == "D" && TextPosition4.text == "H" && TextPosition5.text == "K" && TextPosition6.text == "P" && TextPosition7.text == "R" && TextPosition8.text == "S" && TextPosition9.text == "T" && TextPosition10.text == "Z")
        {
            reussite = true;
        }
        else { 
            reussite = false;
        }

        if (essai == 2 && reussite == false)
        {
            Canvas_Classement_Livre.SetActive(false);
            Vendeur.SetActive(false);
            Video.GetComponent<VideoPlayer>().clip = videoClips[0];
            Curseur.SetActive(true);
            Camera.GetComponent<Click_dialogue>().enabled = true;
            Camera.GetComponent<Camerapourmouvement>().enabled = true;
        }

        if (essai == 1 && reussite == false)
        {
            essai = 2;
            tentative.GetComponent<Text>().text = "Nombre de tentative : 1";
        }
        if (essai == 0 && reussite == false)
        {
            essai = 1;
            tentative.GetComponent<Text>().text = "Nombre de tentative : 2";
            

        }



        if (reussite == true)
        {
            Canvas_Classement_Livre.SetActive(false);
            Vendeur.SetActive(false);
            Video.GetComponent<VideoPlayer>().clip = videoClips[0];
            Curseur.SetActive(true);
            Camera.GetComponent<Click_dialogue>().enabled = true;
            Camera.GetComponent<Camerapourmouvement>().enabled = true;
        }
        
                            

        

    }


    public void retour_position()
    {
        if (position_actuelle >= 1 && Textposition.GetComponent<Text>().text != "")
        {

            position.SetActive(false);
            if (Textposition.GetComponent<Text>().text == "R")
            {
                R.SetActive(true);
                Textposition.GetComponent<Text>().text = "";



            }
            if (Textposition.GetComponent<Text>().text == "Z")
            {
                Z.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "S")
            {
                S.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "D")
            {
                D.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "P")
            {
                P.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "H")
            {
                H.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "T")
            {
                T.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "A")
            {
                A.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "C")
            {
                C.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            if (Textposition.GetComponent<Text>().text == "K")
            {
                K.SetActive(true);
                Textposition.GetComponent<Text>().text = "";


            }
            position_actuelle = position_actuelle - 1;
            onclic = true;
            verif_position_actuelle();
        }


    }


    // Update is called once per frame
    void Update()
    {
        validation();
        verif_position_actuelle();
    }

}

