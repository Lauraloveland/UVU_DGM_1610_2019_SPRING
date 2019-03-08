using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
// Collection of client variables

public string client1 = "Craig";
public string client2 = "Kate";
public string client3 = "Adam";
public string client4 = "Nia";
public string client5 = "Fred";
// Array example

public string[] clientList = new string []{"Graig, Kate, Adam, Nia, Fred"};


// List example 
public List<string> SantasList = new List<string>();


// Array list example
public ArrayList inventory = new ArrayList();


    // Start is called before the first frame update
    void Start()
    {
        SantasList.Add("Jimmy");
        SantasList.Add("Jenny");
        SantasList.Add("Sam");
        SantasList.Add("Ty");
        SantasList.Add("Susie");
        SantasList.Remove("Jimmy");
        SantasList.Remove ("Jojo");


        
        print(clientList[2]);
        print(SantasList[3]);



 inventory.Add (10);
 inventory.Add ("Bob");
 inventory.Add (true);
 inventory.Add (5.2341);

 print(inventory[2]);



        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
