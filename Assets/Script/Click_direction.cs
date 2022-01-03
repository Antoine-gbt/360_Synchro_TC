using UnityEngine;

public class Click_direction : MonoBehaviour
{
    public GameObject go;
    public GameObject fleche_pharmacie;
    public GameObject fleche_magasin;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {

            if (hit.transform.gameObject.tag == "Zone1")
            {
                fleche_pharmacie.GetComponent<Outline>().enabled = true;

            }
            if (hit.transform.gameObject.tag == "Zone2")
            {
                fleche_magasin.GetComponent<Outline>().enabled = true;

            }
        }
        else
        {
            fleche_pharmacie.GetComponent<Outline>().enabled = false;
            fleche_magasin.GetComponent<Outline>().enabled = false;
        }
        }


    
}