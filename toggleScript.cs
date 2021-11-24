using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleScript : MonoBehaviour
{

   

    public static bool toggle = false; //bool to toggle

    public GameObject walkways; //pwalkway game obj
    public GameObject controlList; //controls game obj 

    public GameObject walls;//walls game obj

    public GameObject map;//map game obj

    public void Start() {
       

        controlList.SetActive(false);//make sure control list isnt visable at the start 
    }

  public  void Update() {

        //toggle walkways 
        //off
        if (Input.GetKey(KeyCode.Q))
        {

            toggleWalkwaysOff();
            Debug.Log("WalkwayOff");
        }
        //on
        if (Input.GetKey(KeyCode.W)) {
            toggleWalkwaysOn();
            Debug.Log("WalkwayOn");
        }
        
        //toggle walls
        //off
        if (Input.GetKey(KeyCode.K))
        {

            wallsOff();
            Debug.Log("WallsOff");
        }
        //on
        if (Input.GetKey(KeyCode.L)) {
            wallsOn();
            Debug.Log("WallsOn");
        }

        //toggle controls menu
        //on
        if (Input.GetKey(KeyCode.H))
        {
            if (toggle = true)
            {
                toggleControlsOn();
        
            }
        }
        //off
       else
        {
            toggleControlsOff();
          
            Debug.Log("CONTROLS");

        }

        //toggle map
        //off
        if (Input.GetKey(KeyCode.M))
        {
            if (toggle = true)
            {
                toggleMapOff(); 

            }
        }
        //on
        else
        {
            toggleMapOnn();


        }


    }


     

    //toggle walkways
public void toggleWalkwaysOn()
    {
        walkways.SetActive(true); //set active t
      toggle = true; //set toggle to false
}

    public void toggleWalkwaysOff()
    {

        walkways.SetActive(false);//set active f


        toggle = false; //set toggle to false
    }

    public void wallsOn()
    {
        walls.SetActive(true); //set active t
        toggle = true; //set toggle to t
    }

    public void wallsOff()
    {

        walls.SetActive(false);//turn pause menu off 
        

        toggle = false; //set toggle to false
    }


   



    public void toggleControlsOff()
    {

        controlList.SetActive(false);//set active f

    }
    
    public void toggleControlsOn()
    {

        controlList.SetActive(true);//set active t

    }

    public void toggleMapOff()
    {

        map.SetActive(false);//set active f

    }

    public void toggleMapOnn()
    {

        map.SetActive(true);//set active t

    }


}
