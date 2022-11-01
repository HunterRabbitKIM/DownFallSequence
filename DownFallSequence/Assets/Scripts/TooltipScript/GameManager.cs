using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //MAKER SINGLETON PATTERN
    public bool isPaused;

    public List<Item> items = new List<Item>(); //우리가 어떤 종류의 아이템을 가지고 있는가
    public List<int> itemNumbers = new List<int>();//얼마나 많은 아이템을 가지고 있는가
    public GameObject[] slots;

    //public Dictionary<Item, int> itemDict = new Dictionary<Item, int>();//옵션


    public string place;
    public bool[] WorldTrigger = { false, false, false, false, false };

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);

        
    }

    private void Start()
    {
        place = "HomeTown";
        
        DisplayItems();
    }

    private void Update()
    {
        
    }

    private void DisplayItems()
    {
        #region
        /*for (int i = 0; i < items.Count; i++)
        {
            //아이템 이미지 업데이트
            //slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

            //아이템 갯수 텍스트 엡데이트
            slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();

        }*/
        #endregion

        //무시(?)
        for(int i = 0; i <slots.Length; i++)
        {
            if(i < items.Count)
            {
                //아이템 이미지 업데이트
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

                //아이템 갯수 텍스트 엡데이트
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();
            }
            else //아이템 제거
            {
                //아이템 이미지 업데이트
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                //아이템 갯수 텍스트 엡데이트
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = null;
            }
        }
    }

    public void AddItem(Item _item)
    {
        //만약에 기존 아이템이 있다면 
        if(!items.Contains(_item))
        {
            items.Add(_item);
            itemNumbers.Add(1);
        }
        else//만약 새로운 아이템이 있다면
        {
            Debug.Log("You have alrady have this One!");
            for(int i =0; i < items.Count; i++)
            {
                if(_item == items[i])
                {
                    itemNumbers[i]++;
                }
            }
        }
        DisplayItems();
    }
    public void RemoveItem(Item _item)
    {
        //만약 가방안에 아이템이 있으면 제거
        if(items.Contains(_item))
        {
            
            for(int i=0; i < items.Count; i++)
            {
                if(_item == items[i])
                {
                    itemNumbers[i]--;
                    if(itemNumbers[i]==0)
                    {
                        //아이템을 제거
                        items.Remove(_item);
                        itemNumbers.Remove(itemNumbers[i]);
                    }
                }
            }
        }
        else
        {
            Debug.Log("There is No" + _item + "in my Bags");
        }
        //만약 가방안에 아이템이 없다면

        DisplayItems();
    }
}
