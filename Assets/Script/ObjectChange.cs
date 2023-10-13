using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChange : MonoBehaviour
{
    [SerializeField]
    public GameObject[] gameObjects;
    public int number=0;
    public int i;
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

    }
    GameObject OldObj;
    public void OnClick()
    {
        if (number == 0)
        {
            OldObj=Instantiate(gameObjects[0], new Vector3(0, 0, 0), Quaternion.identity);
            
        }
           
            

        else if (number == 1)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[number], new Vector3(0, 0, 0), Quaternion.identity);

        }
        else if (number == 2)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[number], new Vector3(0, 0, 0), Quaternion.identity);

        }
        else if (number == 3)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[number], new Vector3(0, 0, 0), Quaternion.identity);
        }

      number++;
    }
}


