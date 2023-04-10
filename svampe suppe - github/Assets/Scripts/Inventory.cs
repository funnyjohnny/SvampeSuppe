using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{

    public TMP_Text skovSampeCurrent;
    public TMP_Text grotteSampeCurrent;
    public TMP_Text flødeCurrent;

    public int antalSkovSvampe = 0;
    public int antalGrotteSvampe = 0;
    public int antalFløde = 0;

    public GameObject SkovSvampPrefab;
    public GameObject GrotteSvampPrefab;
    public GameObject FlødePrefab;


    #region Singleton

    public static Inventory instance;
    void Awake()
    {
        
        if (instance != null)
        {
            Debug.LogWarning("More then one Instance of Inventory found!");
            return;
        }
        
        
        instance = this;
    }

    #endregion


    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 30;

    public List<Item> items = new List<Item>();

        public bool Add(Item item)
    {

        if(items.Count >= space)
        {
            Debug.Log("Not enought inventory space");
            return false;
        }


        items.Add(item);

        #region Antal items til UI +
        if (item.name == "SkovSvamp")
        {
            antalSkovSvampe++;
        }else if (item.name == "GrotteSvamp")
        {
            antalGrotteSvampe++;
        }
        else if (item.name == "Fløde")
        {
            antalFløde++;
        }
        #endregion



        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
        
        return true;
    }


    
    

    public void Remove(Item item)
    {
        #region Antal items til UI - / instantiate removed item
        if (item.name == "SkovSvamp")
        {
            antalSkovSvampe--;
            Instantiate(SkovSvampPrefab, transform.position, transform.rotation);
        }
        else if (item.name == "GrotteSvamp")
        {
            antalGrotteSvampe--;
            Instantiate(GrotteSvampPrefab, transform.position, transform.rotation);
        }
        else if (item.name == "Fløde")
        {
            antalFløde--;
            Instantiate(FlødePrefab, transform.position, transform.rotation);
        }
        #endregion



        items.Remove(item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }




    private void Update()
    {
        skovSampeCurrent.text = antalSkovSvampe.ToString();
        grotteSampeCurrent.text = antalGrotteSvampe.ToString();
        flødeCurrent.text = antalFløde.ToString();
    }




}
