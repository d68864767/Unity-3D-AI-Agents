```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Reference to the LibrarianAI component
    private LibrarianAI librarianAI;

    // Initialization
    void Start()
    {
        // Get the LibrarianAI component
        librarianAI = GetComponent<LibrarianAI>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the librarian AI has a response to present
        if (librarianAI.HasResponse())
        {
            // Get the response from the librarian AI
            string response = librarianAI.GetResponse();

            // Present the response to the user
            librarianAI.PresentResponse(response);
        }
    }
}
```
