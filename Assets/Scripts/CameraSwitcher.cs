using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera followCamera;
    [SerializeField] GameObject startUI;
    [SerializeField] CarController carController;

    public void SwitchCamera()
    {
        followCamera.gameObject.SetActive(true);
        startUI.SetActive(false);
        carController.enabled = true;
    }
}
