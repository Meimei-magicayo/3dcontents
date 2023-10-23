using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultposition : MonoBehaviour
{
    public GameObject gameObjects;
    private Quaternion initialRot;
    private Vector3 initialPos;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        initialPos=gameObjects.transform.position;
        initialRot = gameObjects.transform.rotation;
    }
   
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        /*for (i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].transform.rotation =new Vector3(0,0,0);
        }*/
        //gameObjects.GetComponent<ObjCtrl>().enabled = false;
        gameObjects.transform.position = initialPos;
        gameObjects.transform.rotation = initialRot;
        //gameObjects.GetComponent<ObjCtrl>().enabled = true;

    }
}
