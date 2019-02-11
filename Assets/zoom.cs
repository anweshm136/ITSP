using System.Collections;
using UnityEngine;
using System.IO.Ports;

public class zoom : MonoBehaviour {

    public float scaleFactor = 0.05f;
    readonly SerialPort sp = new SerialPort("COM5", 9600);
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    void Zoomobj(int dir)
    {
        if (dir == 3)
        {
            player1.gameObject.transform.localScale+=new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player2.gameObject.transform.localScale+=new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player3.gameObject.transform.localScale+=new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player4.gameObject.transform.localScale+=new Vector3(scaleFactor, scaleFactor, scaleFactor);
        }
        if (dir == 4)
        {
            player1.gameObject.transform.localScale+=new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player2.gameObject.transform.localScale+=new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player3.gameObject.transform.localScale+=new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player4.gameObject.transform.localScale+=new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
        }
            
    }

    

    void Update () {
        if (sp.IsOpen)
        {
            try
            {
                Zoomobj(sp.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }
}
