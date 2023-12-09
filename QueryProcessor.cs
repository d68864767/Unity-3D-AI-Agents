```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class QueryProcessor : MonoBehaviour
{
    // Generate a concise summary from the given web search result
    public string GenerateSummary(string webSearchResult)
    {
        // Extract the main content from the web search result
        string mainContent = ExtractMainContent(webSearchResult);

        // Generate a concise summary from the main content
        string summary = SummarizeContent(mainContent);

        // Return the summary
        return summary;
    }

    // Extract the main content from the given web search result
    private string ExtractMainContent(string webSearchResult)
    {
        // Use a regular expression to extract the main content from the web search result
        // This is a simplified example and may not work for all web pages
        Match match = Regex.Match(webSearchResult, "<div class=\"BNeawe iBp4i AP7Wnd\">(.*?)<div class=\"BNeawe UPmit AP7Wnd\">", RegexOptions.Singleline);

        // If a match was found
        if (match.Success)
        {
            // Return the main content
            return match.Groups[1].Value;
        }
        else
        {
            // If no match was found, return an empty string
            return "";
        }
    }

    // Generate a concise summary from the given main content
    private string SummarizeContent(string mainContent)
    {
        // Use a regular expression to remove all HTML tags from the main content
        string textContent = Regex.Replace(mainContent, "<.*?>", "");

        // Use a regular expression to remove all extra whitespace from the text content
        string summarizedContent = Regex.Replace(textContent, "\\s+", " ");

        // Return the summarized content
        return summarizedContent;
    }
}
```
