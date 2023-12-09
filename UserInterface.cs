```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    // Reference to the input field in the UI
    public InputField userInputField;

    // Reference to the text field in the UI where the AI's response will be displayed
    public Text aiResponseText;

    // Check if the user has entered a query
    public bool HasUserQuery()
    {
        // If the user input field is not empty, return true
        // Otherwise, return false
        return !string.IsNullOrEmpty(userInputField.text);
    }

    // Get the user's query
    public string GetUserQuery()
    {
        // Return the text from the user input field
        return userInputField.text;
    }

    // Present the summary to the user
    public void PresentSummary(string summary)
    {
        // Set the text of the AI response field to the given summary
        aiResponseText.text = summary;

        // Clear the user input field
        userInputField.text = "";
    }
}
```
