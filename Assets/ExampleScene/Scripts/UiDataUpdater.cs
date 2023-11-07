using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class UiDataUpdater : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI HighlightText,selectText,rankText, pop00Text, pop10Text, pop15Text, pop20Text, pop21Text, pop22Text, pop23Text, growthRate2023;
    [SerializeField] WorldMap map;
    // Start is called before the first frame update
    void Start()
    {
        map.onHighlightCountry += ChangeHighlightText;
        map.onSelectCountry += ChangeSelectText;
        map.onUnselectCountry += ChangeSelectText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeHighlightText(object sender,EventArgs e)
    {
        HighlightText.text = map.GetCountryName(map.highlightedCountry);
    }
    void ChangeSelectText(object sender,EventArgs e)
    {
        
        selectText.text = map.GetCountryName(map.selectedCountry);
        rankText.text = map.DataRANKING.ToString("N0");
        pop00Text.text = map.DataPOP00.ToString("N0");
        pop10Text.text = map.DataPOP10.ToString("N0");
        pop15Text.text = map.DataPOP15.ToString("N0");
        pop20Text.text = map.DataPOP20.ToString("N0");
        pop21Text.text = map.DataPOP21.ToString("N0");
        pop22Text.text = map.DataPOP22.ToString("N0");
        pop23Text.text = map.DataPOP23.ToString("N0");
        growthRate2023.text = map.DataGROWTH.ToString();

    }
}
