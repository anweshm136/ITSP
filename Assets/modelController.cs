using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class modelController : MonoBehaviour {

    readonly SerialPort sp = new SerialPort("COM3", 9600);
    public GameObject modelA;
    public GameObject modelB;

    private int modelNumber;
	// Use this for initialization
	void Start () {
        modelNumber = 1;
        modelB.SetActive(false);
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void ModelSwitch(int dir)
    {
        if (dir == 5)
        {
            if (modelNumber == 1)
            {
                modelA.SetActive(false);
                modelB.SetActive(true);
                modelNumber = 2;
            }
            else if (modelNumber == 2)
            {
                modelA.SetActive(true);
                modelB.SetActive(false);
                modelNumber = 1;
            }
        }
    }

	// Update is called once per frame
	void Update () {
        if (sp.IsOpen)
        {
            try
            {
                ModelSwitch(sp.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }
}
