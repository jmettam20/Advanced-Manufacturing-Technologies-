
using UnityEngine;
using UnityEngine.AI;
 
public class PlayerCtrl : MonoBehaviour
{
    public Camera cam; 

    public NavMeshAgent agent;

    public NavMeshSurface surface; 

    Animator anim;

    public GameObject trigger1;
    public GameObject trigger2;

    public bool jumpSw = true;

    void Start() {
        anim = GetComponent<Animator>(); //get animator 
      
    }

   private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Jump Trigger")//if player collides jump
        {
            anim.SetBool("Jump",true);
            trigger1.SetActive(false);
           trigger2.SetActive(false);
            trigger1.GetComponent<Collider>().isTrigger = false;
            trigger2.GetComponent<Collider>().isTrigger = false;

         

            if (jumpSw = true) {
                trigger1.SetActive(true);
                trigger2.SetActive(true);
                trigger1.GetComponent<Collider>().isTrigger = true;
                trigger2.GetComponent<Collider>().isTrigger = true;

                anim.SetBool("Jump", false);
            }
          
        }
        else {
            anim.SetBool("Jump", false);

            jumpSw = false; 
            
        }

    }


    // Update is called once per frame
    void Update()
    {
      

        //clickto move
        //if click gett taget via raycast
        if (Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                agent.SetDestination(hit.point); 
            }
        }

        //walk animation if moving to destination 
       if (agent.hasPath == true)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);

            
        }
    }

}
