using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeMover : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
    public GameObject parent;
    public  Camera cam;
  public  Vector3 start, end;
  public  List<float> list;
    public void OnBeginDrag(PointerEventData eventData)
    {
        start = Input.mousePosition;
        start.z =cam.nearClipPlane;
        start = cam.ScreenToWorldPoint(start);
        print("Start =" + start);
    }

   
    public void OnEndDrag(PointerEventData eventData)
    {
        end = Input.mousePosition;
        end.z = cam.nearClipPlane;
        end = cam.ScreenToWorldPoint(end);
      //  print("End = " + end);
        var dir = end - start;
        // print("Dir = " + dir);
     
        Debug.DrawLine(start, end, Color.white, 5.0f);
       // list.Clear();
         var   R = Vector3.Angle(dir, transform.right);
        list.Add(R);
       // print("R=" + R);
        var U = Vector3.Angle(dir, transform.up);
        list.Add(U);
       // print("U=" + U);
        var F = Vector3.Angle(dir, transform.forward);
        list.Add(F);
       // print("F=" + F);

        var L = Vector3.Angle(dir,-1*transform.right);
        list.Add(L);
     //   print("L=" + L);
        var D = Vector3.Angle(dir,-1*transform.up);
        list.Add(D);
     //   print("D=" + D);
        var B = Vector3.Angle(dir,-1*transform.forward);
        list.Add(B);
        list.Sort();   
      //  print("B=" + B);
        
    }

    // Start is called before the first frame update
    void Start()
    {
       // list = new List<float>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

}
