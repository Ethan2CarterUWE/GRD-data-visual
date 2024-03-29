﻿using UnityEngine;
using TMPro;
public class MapStyleController : MonoBehaviour
{
    public InteractionModes interactionMode;
    public Color top10COUNTRY;
    public Color top25COUNTRY;
    public Color top50COUNTRY;
    public Color top75COUNTRY;
    public Color top100COUNTRY;
    public Color top150COUNTRY;
    public Color top200COUNTRY;


    public bool tryout;

    public Color DefaultColorForCountries;
    public Color DefaultColorForHighlightedCountries;
    public Color DefaultColorForSelectedCountries;
    public Color DefaultColorForNonIntractableCountries;
    public bool ShowCountryNames = true;
    public Color FontColor;
    public Color32 StrokeColor;
    [Range(0,1f)]public float StrokeSize;
    public TMPro.FontStyles FontStyle;

    public void UpdateSettings()
{
    for(int x=0;x<transform.childCount ;x++)
        {
            Transform countryT = transform.GetChild(x).transform;


            if (tryout == true)
            {
                countryT.tag = "Not Selected";
            }
          /*  else if (countryT.tag == "Not Selected")
            {
                countryT.GetComponent<SpriteRenderer>().color = DefaultColorForCountries; 

            }*/

          /*   if (countryT.tag == "Not Selected")
             countryT.GetComponent<SpriteRenderer>().color = DefaultColorForCountries;*/

            else if(countryT.tag == "Selected")
            {
               
                  // countryT.GetComponent<SpriteRenderer>().color = DefaultColorForSelectedCountries;
                 // countryT.GetComponent<SpriteRenderer>().color = Color.magenta;

                
            }

            else if(countryT.tag == "Disabled")
            countryT.GetComponent<SpriteRenderer>().color = DefaultColorForNonIntractableCountries;

            countryT.transform.GetChild(0).gameObject.SetActive(ShowCountryNames);
            if(ShowCountryNames)
            {
            TextMeshProUGUI text = countryT.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            Material mat = text.fontSharedMaterial;
            mat.shaderKeywords = new string[]{"OUTLINE_ON"};
            text.color = FontColor;
            text.fontStyle = FontStyle;
            text.outlineWidth = StrokeSize;
            text.outlineColor = StrokeColor;
            text.text = countryT.name;

               
            }
        }


    

        
    }
}
public enum InteractionModes
{
    Multiple,Single,
}
