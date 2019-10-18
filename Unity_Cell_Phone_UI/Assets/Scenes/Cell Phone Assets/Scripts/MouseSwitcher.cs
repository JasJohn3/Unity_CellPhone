using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MouseSwitcher : MonoBehaviour
{
    public RigidbodyFirstPersonController controller;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            controller.mouseLook.SetCursorLock(!controller.mouseLook.lockCursor);
        }    
    }
}
