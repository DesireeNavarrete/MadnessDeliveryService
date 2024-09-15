using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorEmi : MonoBehaviour
{
    /*---------------------------AÑADIR/ARREGLAR-------------------------------------
     *solo un obj con el emisivo a la vez
     * raycast?
     *      
     *  
     *      
     * 
     * 
     * 
     */
    public Color c1, c2;
    //Material myRenderer;


    void Start()
    {
        //myRenderer = GetComponent<Renderer>().material;
        //myRenderer.SetColor("_EmissionColor", c1); //color base
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mesa" || other.gameObject.tag == "cajaV" || other.gameObject.tag == "cajaR" || other.gameObject.tag == "caja")
        {
            //print(other.transform.name);
            foreach (Transform child in other.transform)
            {
                child.gameObject.GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", c2);
                //print(child);
            }
        }
    }


    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "mesa" || other.gameObject.tag == "cajaV" || other.gameObject.tag == "cajaR" || other.gameObject.tag == "cajaA")
        {
            foreach (Transform child in other.gameObject.transform)
            {
                child.gameObject.GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", c2);
            }
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "mesa" || other.gameObject.tag == "cajaV" || other.gameObject.tag == "cajaR" || other.gameObject.tag == "cajaA")
        {
            foreach (Transform child in other.gameObject.transform)
            {
                child.gameObject.GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", c1);
            }
        }
    }
}
