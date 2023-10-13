using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanged : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameObjects;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        number = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (number == 0)
            {

                //Destroy(clickedGameObject);
                number++;
                Instantiate(gameObjects[number], new Vector3(0, 0, 0), Quaternion.identity);
            }
            else if (number == 1)
            {
                //Destroy(clickedGameObject);
                number++;
                Instantiate(gameObjects[number], new Vector3(0, 0, 0), Quaternion.identity);
            }
            else if (number == 2)
            {

                //Destroy(clickedGameObject);
                number++;
                Instantiate(gameObjects[number], new Vector3(0, 0, 0), Quaternion.identity);
                number = 0;
            }
        }
    
    }
}
