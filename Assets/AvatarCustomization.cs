using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UnityEngine.UI;

public class AvatarCustomization : MonoBehaviour
{
    public DynamicCharacterAvatar avatar;

    public Dropdown hairDropdown;
    public Dropdown shoesDropdown;
    public Dropdown clothingDropdown;

    void Start()
    {
        hairDropdown.onValueChanged.AddListener(delegate { ChangeHair(); });
        shoesDropdown.onValueChanged.AddListener(delegate { Changeshoes(); });
        clothingDropdown.onValueChanged.AddListener(delegate { ChangeClothing(); });
    }

    void ChangeHair()
    {
        string selectedHair = hairDropdown.options[hairDropdown.value].text;
        avatar.SetSlot("Hair", selectedHair);
        avatar.BuildCharacter();
    }

    void Changeshoes()
    {
        string selectedEyeColor = shoesDropdown.options[shoesDropdown.value].text;
        avatar.SetColor("Shoes", ColorUtility.TryParseHtmlString(selectedEyeColor, out Color color) ? color : Color.white);
        avatar.BuildCharacter();
    }

    void ChangeClothing()
    {
        string selectedClothing = clothingDropdown.options[clothingDropdown.value].text;
        avatar.SetSlot("Clothing", selectedClothing);
        avatar.BuildCharacter();
    }
}