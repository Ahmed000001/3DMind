using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CubeMover : MonoBehaviour,IDragHandler
{
    public GameObject parent;
    public void OnDrag(PointerEventData eventData)
    {
         if(Mathf.Abs(eventData.delta.x)> Mathf.Abs(eventData.delta.y))
        {
         if (Vector3.Angle(transform.forward, Camera.main.transform.forward) > 45)
            {
              transform.position=Vector3.MoveTowards(transform.position,transform.position + Mathf.Sign(eventData.delta.x)*2*transform.forward, Time.deltaTime * 10);
            }
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
