using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectChange : MonoBehaviour
{
    [SerializeField]
    public GameObject[] gameObjects;
    public int i,n,a,b,c,d;
    public int Randnumber;
    public int number=0;
    int start = 0;
    int end = 3;

    List<int> numbers = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        n = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    GameObject OldObj;
    public void OnClick()
    {
        /* for (int i = start; i <= end; i++)
         {
             numbers.Add(i);
         }


         while (n==1) { 
             int index = Random.Range(0, numbers.Count);

             int ransu = numbers[index];

             if (ransu == 0 && a != 0)
             {
                 if (number != 0)
                 {
                     Destroy(OldObj);
                 }
                 OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, 0), Quaternion.identity);
                 numbers.RemoveAt(index);
                 n = 0;

             }



             else if (ransu == 1 )
             {
                 if (number != 0)
                 {
                     Destroy(OldObj);
                 }

                 OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, 0), Quaternion.identity);
                 numbers.RemoveAt(index);
                 n = 0;

             }
             else if (ransu == 2)
             {
                 if (number != 0)
                 {
                     Destroy(OldObj);
                 }
                 OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, 0), Quaternion.identity);
                 numbers.RemoveAt(index);
                 n = 0;

             }
             else if (ransu== 3)
             {
                 if (number != 0)
                 {
                     Destroy(OldObj);
                 }
                 OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, 0), Quaternion.identity);
                 numbers.RemoveAt(index);
                 n = 0;
             }        





         }




          number++;*/

        if (number >=gameObjects.Length)
        {
            SceneManager.LoadScene("tytle");
        }
        if (number == 0)
        {
            OldObj=Instantiate(gameObjects[0], new Vector3(0, 40, -470), Quaternion.Euler(0,180,0));
            
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

    public void OnReset()
    {

        OldObj.transform.Rotate(0, 0, 0);
    }
}


