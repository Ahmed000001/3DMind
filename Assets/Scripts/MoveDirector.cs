using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoveDirector : MonoBehaviour,IDragHandler
{
    Vector3 strat, end;
    public GameObject go;
   public float Angle;
    public void OnDrag(PointerEventData eventData)
    {
                  

         
       var Fangle= Vector3.Angle(transform.forward, Vector3.forward);
        var Rangle = Vector3.Angle(transform.right, Vector3.right);


        if (Fangle > 90)
            Fangle -= 180;
        //if (Rangle > 90)
        //    Rangle -= 180;
      //  Rangle = Mathf.Abs(Rangle);
        Fangle = Mathf.Abs(Fangle);
        print("RAngle= " + Rangle);
        print("FAgle= " +Fangle);
        var x = eventData.delta.x;
        var y = eventData.delta.y;
        
        if(Mathf.Abs(x)> Mathf.Abs(y))
        {
            if (Fangle < 60)
            {
                if (Rangle <120)
                {
                    go.transform.position = Vector3.MoveTowards(go.transform.position, go.transform.position + transform.up * Mathf.Sign(-x), 10 * Time.deltaTime);
                }
                else
                {
                    go.transform.position = Vector3.MoveTowards(go.transform.position, go.transform.position + transform.right * Mathf.Sign(-x), 10 * Time.deltaTime);
                }
            }
            else
            {

            }
        }
        else if (Mathf.Abs(y) > Mathf.Abs(x))
        {

        }
       
    }

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
