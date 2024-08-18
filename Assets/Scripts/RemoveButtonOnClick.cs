using UnityEngine;
using UnityEngine.UI;

public class RemoveButtonOnClick : MonoBehaviour
{
    private Button button;

    void Start()
    {
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();
        if (button != null)
        {
            // Add a listener to call RemoveButton when the button is clicked
            button.onClick.AddListener(RemoveButton);
        }
        else
        {
            Debug.LogError("Button component not found!");
        }
    }

    void RemoveButton()
    {
        // Remove the button GameObject from the scene
        Destroy(gameObject);
    }
}
