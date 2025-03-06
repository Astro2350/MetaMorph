using UnityEngine;

public class UINavigation : MonoBehaviour
{
    public GameObject profilePanel, watchAdsPanel, leaderboardPanel, explorePanel, impactPanel;

    void Start()
    {
        Debug.Log("UINavigation started - All panels OFF at start");

        // Hide all panels at the beginning
        HideAllPanels();
    }

    public void ShowPanel(GameObject panel)
    {
        Debug.Log("Switching to: " + panel.name);

        HideAllPanels();

        panel.SetActive(true);
    }

    private void HideAllPanels()
    {
        profilePanel.SetActive(false);
        watchAdsPanel.SetActive(false);
        leaderboardPanel.SetActive(false);
        explorePanel.SetActive(false);
        impactPanel.SetActive(false);

        Debug.Log("All panels are now hidden");
    }
}