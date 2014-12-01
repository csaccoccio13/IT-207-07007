using UnityEngine;
using System.Collections;

public class CSharpTut : MonoBehaviour 
{
    // Use this for initialization
	void Start () 
    {
        Variables myClass;
        myClass = new Variables();

        myClass.Test();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}


public class Variables
{
    public void Test()
    {
        int x = 100;
        int y;
        y = 150;

        int z;

        z = x + y;

        Debug.Log(string.Format("{0}", z));

        string Name = "Joe";
        string Surname = "Schmoe";

        Debug.Log(Name + " " + Surname);
        Debug.Log(string.Concat(Name, " ", Surname));

        if(/* Condition */ z <= 200)                    //Conditional With
        { /* True Part*/
            Debug.Log("Z is less than 200");                //True Part
        }
        else
        { /* False Part */
            Debug.Log("Z is greater than 200");             //False Part
        }

        Debug.Log( (z >= 150) ? "Z is greater than 150" : "Z is less than 150"); //Ternary Opperator

        for (/* Initializer */ int i = 0; /* Condition */ i < 10; /* Increment */  i++ )
        {
            /* statements */
            Debug.Log(i);
        }

        for(int i = 10; i > 0; i--)
        {
            Debug.Log(i);       
        }
    }
}
