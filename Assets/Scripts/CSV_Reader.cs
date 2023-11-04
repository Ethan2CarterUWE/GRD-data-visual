using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSV_Reader : MonoBehaviour
{
   [SerializeField] private TextAsset _textDataSet;

    [System.Serializable]
    public class Country
    {
        public int Rank;
        public string CountryName;
        public int Population23;
        public int Population22;
        public int Population21;
        public int Population20;
        public int Population15;
        public int Population10;
        public int Population00;
        public float GrowthRate;
    }

    [System.Serializable]
    public class CountryList
    {
        public Country[] country;
    }

    public CountryList myCountryList = new CountryList();
    void Start()
    {
        ReadCSV();
    }

    void ReadCSV()
    {
        string[] data = _textDataSet.text.Split(new string[] {",","\n"}, StringSplitOptions.None);

        int tableSize = data.Length / 10 - 1;
        
        myCountryList.country = new Country[tableSize];

        for (int i = 0; i < tableSize; i++)
        {
            myCountryList.country[i] = new Country();
            myCountryList.country[i].Rank = int.Parse( data[10 * (i + 1)]);
            myCountryList.country[i].CountryName = data[10 * (i + 1) + 1];
            myCountryList.country[i].Population23 = int.Parse(data[10 * (i + 1)+2]);
            myCountryList.country[i].Population22 = int.Parse(data[10 * (i + 1)+3]);
            myCountryList.country[i].Population21 = int.Parse(data[10 * (i + 1)+4]);
            myCountryList.country[i].Population20 = int.Parse(data[10 * (i + 1)+5]);
            myCountryList.country[i].Population15 = int.Parse(data[10 * (i + 1)+6]);
            myCountryList.country[i].Population10 = int.Parse(data[10 * (i + 1)+7]);
            myCountryList.country[i].Population00 = int.Parse(data[10 * (i + 1)+8]);
            myCountryList.country[i].GrowthRate = float.Parse(data[10 * (i + 1)+9]);
        }
    }
}
