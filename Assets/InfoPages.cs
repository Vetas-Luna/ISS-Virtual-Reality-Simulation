using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPages : MonoBehaviour
{

    [Tooltip("Textbox to make pageable.")]
    public TextMeshProUGUI textBox; 

    [Tooltip("Whether or not the text box will loop back to the first/last page.")]
    public bool Looping;

    [Tooltip("Text files of information to display on each page. Should be added in order.")]
    public List<TextAsset> pages;

    private List<string> pagesText = new List<string>();
    private int currPage;

    // Start is called before the first frame update
    void Start()
    {
        for( int i = 0; i < pages.Count; i++)
        {
            pagesText.Add(pages[i].text);
        }
        if (pages.Count == 0)
        {
            throw new ArgumentException("List cannot be of length 0.");
        }

        currPage = 0;
        textBox.text = pagesText[currPage];
    }


    public void nextPage()
    {
        if (currPage < pages.Count - 1)
            currPage += 1;
        else if (Looping)
            currPage = 0;

        textBox.text = pagesText[currPage];
    }

    public void prevPage()
    {
        if (currPage > 0)
            currPage -= 1;
        else if (Looping)
            currPage = pages.Count - 1;

        textBox.text = pagesText[currPage];
    }
}
