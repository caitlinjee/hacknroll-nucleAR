using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ColourChanger : MonoBehaviourPunCallbacks
{

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            rend = GetComponent<Renderer>();
            rend.material.SetColor("_Color", Random.ColorHSV());
        }
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
