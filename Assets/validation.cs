using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validation : MonoBehaviour
{

    public Transform player;
    public Text scoretext;
    // Update is called once per frame
    void Update()
    {
        scoretext.text = (player.position).ToString("0");
    }
}
