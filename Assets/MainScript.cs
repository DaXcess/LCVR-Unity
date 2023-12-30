using Microsoft.MixedReality.Toolkit.Experimental.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.UI;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NonNativeKeyboard.Instance.PresentKeyboard();
    }

    private ActionBasedController controller;

    IEnumerator Huh()
    {
        yield return null;

        var controllerObject = GameObject.Find("Right Controller");
        controller = controllerObject.AddComponent<ActionBasedController>();
        var interactor = controllerObject.AddComponent<XRRayInteractor>();
        var visual = controllerObject.AddComponent<XRInteractorLineVisual>();

        visual.lineBendRatio = 1;

        controller.positionAction = new InputActionProperty(Actions.XR_RightHand_Position);
        controller.rotationAction = new InputActionProperty(Actions.XR_RightHand_Rotation);
        controller.trackingStateAction = new InputActionProperty(Actions.XR_RightHand_TrackingState);

        controller.selectAction = new InputActionProperty(Actions.XR_RightHand_Grip_Button);
        controller.selectActionValue = new InputActionProperty(Actions.XR_RightHand_Grip);
        controller.activateAction = new InputActionProperty(Actions.XR_RightHand_Trigger_Button);
        controller.activateActionValue = new InputActionProperty(Actions.XR_RightHand_Trigger);
        controller.uiPressAction = new InputActionProperty(Actions.XR_RightHand_Trigger_Button);
        controller.uiPressActionValue = new InputActionProperty(Actions.XR_RightHand_Trigger);
        controller.uiScrollAction = new InputActionProperty(Actions.XR_RightHand_Thumbstick);
        controller.rotateAnchorAction = new InputActionProperty(Actions.XR_RightHand_Thumbstick);
        controller.translateAnchorAction = new InputActionProperty(Actions.XR_RightHand_Thumbstick);
        controller.scaleToggleAction = new InputActionProperty(Actions.XR_RightHand_Thumbstick_Click);
        controller.scaleDeltaAction = new InputActionProperty(Actions.XR_RightHand_Thumbstick);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

public class Actions
{
    public static InputAction XR_HeadPosition = new("Position", binding: "<XRHMD>/centerEyePosition");
    public static InputAction XR_HeadRotation = new("Rotation", binding: "<XRHMD>/centerEyeRotation");
    public static InputAction XR_HeadTrackingState = new("Tracking State", binding: "<XRHMD>/trackingState");

    public static InputAction XR_RightHand_Position = new(binding: "<XRController>{RightHand}/devicePosition");
    public static InputAction XR_RightHand_Rotation = new(binding: "<XRController>{RightHand}/deviceRotation");
    public static InputAction XR_RightHand_TrackingState = new(binding: "<XRController>{RightHand}/trackingState");
    public static InputAction XR_RightHand_IsTracked = new(binding: "<XRController>{RightHand}/isTracked");
    public static InputAction XR_RightHand_Thumbstick = new(binding: "<XRController>{RightHand}/Primary2DAxis");
    public static InputAction XR_RightHand_Thumbstick_Click = new(binding: "<XRController>{RightHand}/{Primary2DAxisClick}");
    public static InputAction XR_RightHand_Grip_Button = new(binding: "<XRController>{RightHand}/gripButton");
    public static InputAction XR_RightHand_Grip = new(binding: "<XRController>{RightHand}/{Grip}");
    public static InputAction XR_RightHand_Trigger_Button = new(binding: "<XRController>{RightHand}/{TriggerButton}");
    public static InputAction XR_RightHand_Trigger = new(binding: "<XRController>{RightHand}/{Trigger}");

    public static InputAction XR_LeftHand_Position = new(binding: "<XRController>{LeftHand}/devicePosition");
    public static InputAction XR_LeftHand_Rotation = new(binding: "<XRController>{LeftHand}/deviceRotation");
    public static InputAction XR_LeftHand_TrackingState = new(binding: "<XRController>{LeftHand}/trackingState");
    public static InputAction XR_LeftHand_IsTracked = new(binding: "<XRController>{LeftHand}/isTracked");
    public static InputAction XR_LeftHand_Thumbstick = new(binding: "<XRController>{LeftHand}/Primary2DAxis");
    public static InputAction XR_LeftHand_Thumbstick_Click = new(binding: "<XRController>{LeftHand}/{Primary2DAxisClick}");
    public static InputAction XR_LeftHand_Grip_Button = new(binding: "<XRController>{LeftHand}/gripButton");
    public static InputAction XR_LeftHand_Grip = new(binding: "<XRController>{LeftHand}/{Grip}");
    public static InputAction XR_LeftHand_Trigger_Button = new(binding: "<XRController>{LeftHand}/{TriggerButton}");
    public static InputAction XR_LeftHand_Trigger = new(binding: "<XRController>{LeftHand}/{Trigger}");

    // Buttons are float values, probably because some controllers allow these to be partially pressed
    public static InputAction XR_Button_A = new(binding: "<XRController>{RightHand}/primaryButton");
    public static InputAction XR_Button_B = new(binding: "<XRController>{RightHand}/secondaryButton");
    public static InputAction XR_Button_X = new(binding: "<XRController>{LeftHand}/primaryButton");
    public static InputAction XR_Button_Y = new(binding: "<XRController>{LeftHand}/secondaryButton");

    public static InputAction XR_Controller_Position = new(binding: "<XRController>/devicePosition");
    public static InputAction XR_Controller_Rotation = new(binding: "<XRController>/deviceRotation");

    // Maybe, maybe not, probably will be intercepted by SteamVR anyways unless something like Oculus or VDXR is being used
    public static InputAction XR_Menu = new(binding: "<XRController>{LeftHand}/menu");

    static Actions()
    {
        XR_HeadPosition.Enable();
        XR_HeadRotation.Enable();
        XR_HeadTrackingState.Enable();

        XR_RightHand_Position.Enable();
        XR_RightHand_Rotation.Enable();
        XR_RightHand_TrackingState.Enable();
        XR_RightHand_IsTracked.Enable();
        XR_RightHand_Thumbstick.Enable();
        XR_RightHand_Thumbstick_Click.Enable();
        XR_RightHand_Grip_Button.Enable();
        XR_RightHand_Grip.Enable();
        XR_RightHand_Trigger_Button.Enable();
        XR_RightHand_Trigger.Enable();

        XR_LeftHand_Position.Enable();
        XR_LeftHand_Rotation.Enable();
        XR_LeftHand_TrackingState.Enable();
        XR_LeftHand_IsTracked.Enable();
        XR_LeftHand_Thumbstick.Enable();
        XR_LeftHand_Thumbstick_Click.Enable();
        XR_LeftHand_Grip_Button.Enable();
        XR_LeftHand_Grip.Enable();
        XR_LeftHand_Trigger_Button.Enable();
        XR_LeftHand_Trigger.Enable();

        XR_Button_A.Enable();
        XR_Button_B.Enable();
        XR_Button_X.Enable();
        XR_Button_Y.Enable();

        XR_Controller_Position.Enable();
        XR_Controller_Rotation.Enable();
    }
}
