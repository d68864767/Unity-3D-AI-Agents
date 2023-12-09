```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibrarianAI : MonoBehaviour
{
    // Reference to the WebBrowserInteraction component
    private WebBrowserInteraction webBrowserInteraction;

    // Reference to the UserInterface component
    private UserInterface userInterface;

    // Reference to the QueryProcessor component
    private QueryProcessor queryProcessor;

    // Initialization
    void Start()
    {
        // Get the WebBrowserInteraction component
        webBrowserInteraction = GetComponent<WebBrowserInteraction>();

        // Get the UserInterface component
        userInterface = GetComponent<UserInterface>();

        // Get the QueryProcessor component
        queryProcessor = GetComponent<QueryProcessor>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the user has entered a query
        if (userInterface.HasUserQuery())
        {
            // Get the user's query
            string userQuery = userInterface.GetUserQuery();

            // Conduct a web search on the query
            string webSearchResult = webBrowserInteraction.ConductWebSearch(userQuery);

            // Process the web search result to generate a concise summary
            string summary = queryProcessor.GenerateSummary(webSearchResult);

            // Present the summary to the user
            userInterface.PresentSummary(summary);
        }
    }
}
```
