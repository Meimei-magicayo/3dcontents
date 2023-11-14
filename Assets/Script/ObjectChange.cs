using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectChange : MonoBehaviour
{
    [SerializeField]
    public GameObject[] gameObjects;
    [SerializeField]
    private Quaternion[] initialRot;

    [SerializeField] private Vector3[] initialPos;
    public int i,n,a,b,c,d;
    public int Randnumber;
    public int number=0;
    int start = 1;
    int end = 15;
    int count = 1;

 


    List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }
        n = 1;   
    }

    // Update is called once per frame
    void Update()
    {

    }
    GameObject OldObj;
    public void OnClick()
    {






        if (number >=15)
        {
            SceneManager.LoadScene("tytle");
        }
        int index = Random.Range(0, numbers.Count);

            int ransu = numbers[index];
        Debug.Log(ransu);

        if (number== 0)
        {
  
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0,-460), Quaternion.Euler(0, 0, 0));
            //OldObj=Instantiate(gameObjects[0], new Vector3(0, -10, -460), Quaternion.Euler(0,180,0));
 
        }
           
            

        else if (number== 1)
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
      
        }
        else if (number == 2)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 3)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 4)
        {
            Destroy(OldObj);// kodomo
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 5)
        {
            Destroy(OldObj);//kodomo
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 6)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 7)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 8)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 9)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 10)
        {
            Destroy(OldObj);// kodomo
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 11)
        {
            Destroy(OldObj);//kodomo
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 12)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 13)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 14)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        else if (number == 15)
        {
            Destroy(OldObj);
            OldObj = Instantiate(gameObjects[ransu], new Vector3(0, 0, -460), Quaternion.Euler(0, 0, 0));
        }
        
        number++;
        numbers.RemoveAt(index);
    }


}


