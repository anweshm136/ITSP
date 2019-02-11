using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Main_script : MonoBehaviour
{
    readonly SerialPort sp = new SerialPort("COM7", 9600);
    public float scaleFactor = 0.05f;
    public float rotationSpeed = 20;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject player6;
    public GameObject player7;
    public GameObject player8;


    void Rotateobj(int dir)
    {
        if (dir == 1)
        {
            player1.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            player2.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            player3.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            player4.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            player5.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            player6.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            player7.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            player8.gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        }
        if (dir == 2)
        {
            player1.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            player2.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            player3.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            player4.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            player5.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            player6.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            player7.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
            player8.gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);

        }

    }

    void Zoomobj(int dir)
    {
        if (dir == 4)
        {
            player1.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player2.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player3.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player4.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player5.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player6.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player7.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
            player8.gameObject.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
        }
        if (dir == 3)
        {
            player1.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player2.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player3.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player4.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player5.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player6.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player7.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
            player8.gameObject.transform.localScale += new Vector3(-scaleFactor, -scaleFactor, -scaleFactor);
        }

    }

    void ModelSwitch(int dir)
    {
        if (dir == 5)
        {
            player5.GetComponentInChildren<Renderer>().enabled = true;
            player6.GetComponentInChildren<Renderer>().enabled = true;
            player7.GetComponentInChildren<Renderer>().enabled = true;
            player8.GetComponentInChildren<Renderer>().enabled = true;
            Renderer[] renderers1 = player1.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers1)
                r.enabled = false;
            Renderer[] renderers2 = player2.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers2)
                r.enabled = false;
            Renderer[] renderers3 = player3.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers3)
                r.enabled = false;
            Renderer[] renderers4 = player4.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers4)
                r.enabled = false;
            Debug.Log("getting dir5");
        }
        else if (dir == 6)
        {
            player5.GetComponentInChildren<Renderer>().enabled = false;
            player6.GetComponentInChildren<Renderer>().enabled = false;
            player7.GetComponentInChildren<Renderer>().enabled = false;
            player8.GetComponentInChildren<Renderer>().enabled = false;
            Renderer[] renderers1 = player1.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers1)
                r.enabled = true;
            Renderer[] renderers2 = player2.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers2)
                r.enabled = true;
            Renderer[] renderers3 = player3.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers3)
                r.enabled = true;
            Renderer[] renderers4 = player4.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers4)
                r.enabled = true;
            Debug.Log("getting dir6");
        }

        else if(dir==1 || dir == 2)
        {
            Rotateobj(dir);
        }
        else if(dir==3 || dir == 4)
        {
            Zoomobj(dir);
        }

    }

    /*void ModelSwitch1(int dir)
    {

        if (dir == 5)
        {
            Debug.Log("getting dir5");
            player5.SetActive(true);
            player6.SetActive(true);
            player7.SetActive(true);
            player8.SetActive(true);
            player1.SetActive(false);
            player2.SetActive(false);
            player3.SetActive(false);
            player4.SetActive(false);

        }
        return;
    }

    void ModelSwitch2(int dir)
    {
        if (dir == 6)
        {
            Debug.Log("getting dir6");
            player1.SetActive(true);
            player2.SetActive(true);
            player3.SetActive(true);
            player4.SetActive(true);
            player5.SetActive(false);
            player6.SetActive(false);
            player7.SetActive(false);
            player8.SetActive(false);

        }
        return;
    }   */


    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
        player5.GetComponentInChildren<Renderer>().enabled = false;
        player6.GetComponentInChildren<Renderer>().enabled = false;
        player7.GetComponentInChildren<Renderer>().enabled = false;
        player8.GetComponentInChildren<Renderer>().enabled = false;

        /* player5.SetActive(false);
         player6.SetActive(false);
         player7.SetActive(false);
         player8.SetActive(false);*/
    }

    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                Debug.Log(sp.ReadByte());
                
                Rotateobj(sp.ReadByte());
                Zoomobj(sp.ReadByte());
                ModelSwitch(sp.ReadByte());


            }
            catch (System.Exception)
            {

            }
        }

    }
}
