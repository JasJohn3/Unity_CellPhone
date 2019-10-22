using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MouseSwitcher : MonoBehaviour
{
    public RigidbodyFirstPersonController controller;
    // Update is called once per frame
    public GameObject cellPhone;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            controller.mouseLook.SetCursorLock(!controller.mouseLook.lockCursor);
            if (controller.mouseLook.lockCursor == true)
            {
                cellPhone.SetActive(false);
            }
            else
            {
                toggleObject(cellPhone);
            }
            


        }    
    }
    public void toggleObject(GameObject objectToToggle)
    {
        objectToToggle.SetActive(!objectToToggle.activeInHierarchy);
    }
}
