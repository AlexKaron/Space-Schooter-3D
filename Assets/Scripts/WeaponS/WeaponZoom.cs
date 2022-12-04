using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{

[SerializeField] Camera fpsCamera;
[SerializeField] float zoomedOutFOV = 60f;
[SerializeField] float zoomedInFOV = 20f;

    bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
            }
        }
    }

}






    //[SerializeField] Camera fpsCamera;
    //[SerializeField] float zoomedOutFOV = 60f;
    //[SerializeField] float zoomedInFOV = 20f;
    //[SerializeField] float zoomOutSensitivity =2f;
    //[SerializeField] float zoomInSensitivity =.5f;

    //bool zoomedInToggle = false;

 

  // private void Update()
   // {
       // if (Input.GetMouseButtonDown(1))
      //  {
           // if (zoomedInToggle == false)
           // {
              //  zoomedInToggle = true;
                //fpsCamera.fieldOfView = zoomedInFOV;
                //fpsController.mouseLook.XSensitivity = zoomInSensitivity;
                //fpsController.mouseLook.YSensitivity = zoomInSensitivity;
                //ZoomIn();
           // }
           // else
          // {
                //zoomedInToggle = false;
                //fpsCamera.fieldOfView = zoomedOutFOV;
               //fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
              // fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
               // ZoomOut();
           // }
       //}
   // }

   // private void ZoomIn()
    //{
       // zoomedInToggle = true;
       // fpsCamera.fieldOfView = zoomedInFOV;
        //fpsController.mouseLook.XSensitivity = zoomInSensitivity;
       // fpsController.mouseLook.YSensitivity = zoomInSensitivity;
  //  }

   // private void ZoomOut()
   // {
        //zoomedInToggle = false;
     //   fpsCamera.fieldOfView = zoomedOutFOV;
      //  fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
       // fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
   // }

