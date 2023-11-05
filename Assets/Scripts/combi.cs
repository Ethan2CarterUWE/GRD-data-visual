using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CSV_Reader;

public class combi : MonoBehaviour
{

    /*
     
     include both scripts

    if selected country
     
     
     */


    CSV_Reader readerr;
    WorldMap mapp;

    GameObject cubee;


    private void Start()
    {        
         readerr = GameObject.FindAnyObjectByType<CSV_Reader>();
         mapp = GameObject.FindAnyObjectByType<WorldMap>();



    }

    private void Update()
    {
        //this keeps going cause its an update

       if (mapp.selectedCountry == Country.Brazil)
        {
            Debug.Log("WE ARE COOKING");
          /*  for (int i = 0; i < 200; i++)
            {
                readerr.myCountryList.country[i].CountryName //= mapp.selectedCountry.ToString();
            }
          */
        }
    }











    //compare list
    //








}
