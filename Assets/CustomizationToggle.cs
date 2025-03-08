using UnityEngine;

public class CustomizationToggle : MonoBehaviour
{
    public Animator avatarAnimator;
    public GameObject customizationUI;
    private bool isCustomizationOpen = false;

    public void ToggleCustomization()
    {
        if (customizationUI.activeSelf)
        {
            // Close Customization UI
            avatarAnimator.SetTrigger("MoveRight");
            customizationUI.SetActive(false);
        }
        else
        {
            // Open Customization UI
            avatarAnimator.SetTrigger("MoveLeft");
            customizationUI.SetActive(true);
        }
    }
}