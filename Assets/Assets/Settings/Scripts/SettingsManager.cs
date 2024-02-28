using TMPro;
using UnityEngine;

namespace LCVR.UI.Settings
{
    public class SettingsManager : MonoBehaviour
    {
        [Header("Templates")]

        [SerializeField] private GameObject categoryTemplate;
        [SerializeField] private GameObject dropdownTemplate;
        [SerializeField] private GameObject textTemplate;
        [SerializeField] private GameObject numberTemplate;
        [SerializeField] private GameObject sliderTemplate;
        [SerializeField] private GameObject booleanTeamplate;

        [SerializeField] private Transform content;

        [Header("Specific Fields")]

        [SerializeField] private TextMeshProUGUI versionText;
        [SerializeField] private TextMeshProUGUI descriptionText;
        [SerializeField] private TMP_Dropdown runtimesDropdown;

        // Function implementations are available in the mod code. They are only here for referencing!

        public void PlayButtonPressSFX()
        {
            throw null;
        }

        public void PlayCancelSFX()
        {
            throw null;
        }

        public void PlayHoverSFX()
        {
            throw null;
        }

        public void PlayChangeSFX()
        {
            throw null;
        }

        public void SetOpenXRRuntime(int index)
        {
            throw null;
        }

        public void UpdateValue(string category, string name, object value)
        {
            throw null;
        }

        public void UpdateDescription(string title, string description)
        {
            descriptionText.text = $"<b>{title}</b>\n\n{description}";
        }
    }
}