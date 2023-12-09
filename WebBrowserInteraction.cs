```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;

public class WebBrowserInteraction : MonoBehaviour
{
    // The base URL for the web search
    private string baseUrl = "https://www.google.com/search?q=";

    // Conduct a web search on the given query
    public string ConductWebSearch(string query)
    {
        // Replace spaces in the query with '+'
        string formattedQuery = query.Replace(" ", "+");

        // Create the full URL for the web search
        string fullUrl = baseUrl + formattedQuery;

        // Create a WebRequest to the full URL
        WebRequest request = WebRequest.Create(fullUrl);

        // Get the WebResponse from the WebRequest
        WebResponse response = request.GetResponse();

        // Get the Stream from the WebResponse
        Stream dataStream = response.GetResponseStream();

        // Create a StreamReader for the Stream
        StreamReader reader = new StreamReader(dataStream);

        // Read the content from the StreamReader
        string responseFromServer = reader.ReadToEnd();

        // Clean up the StreamReader and the WebResponse
        reader.Close();
        response.Close();

        // Return the content
        return responseFromServer;
    }
}
```
