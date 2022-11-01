using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //MAKER SINGLETON PATTERN
    public bool isPaused;

    public List<Item> items = new List<Item>(); //�츮�� � ������ �������� ������ �ִ°�
    public List<int> itemNumbers = new List<int>();//�󸶳� ���� �������� ������ �ִ°�
    public GameObject[] slots;

    //public Dictionary<Item, int> itemDict = new Dictionary<Item, int>();//�ɼ�


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
            //������ �̹��� ������Ʈ
            //slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

            //������ ���� �ؽ�Ʈ ������Ʈ
            slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();

        }*/
        #endregion

        //����(?)
        for(int i = 0; i <slots.Length; i++)
        {
            if(i < items.Count)
            {
                //������ �̹��� ������Ʈ
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

                //������ ���� �ؽ�Ʈ ������Ʈ
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();
            }
            else //������ ����
            {
                //������ �̹��� ������Ʈ
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                //������ ���� �ؽ�Ʈ ������Ʈ
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = null;
            }
        }
    }

    public void AddItem(Item _item)
    {
        //���࿡ ���� �������� �ִٸ� 
        if(!items.Contains(_item))
        {
            items.Add(_item);
            itemNumbers.Add(1);
        }
        else//���� ���ο� �������� �ִٸ�
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
        //���� ����ȿ� �������� ������ ����
        if(items.Contains(_item))
        {
            
            for(int i=0; i < items.Count; i++)
            {
                if(_item == items[i])
                {
                    itemNumbers[i]--;
                    if(itemNumbers[i]==0)
                    {
                        //�������� ����
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
        //���� ����ȿ� �������� ���ٸ�

        DisplayItems();
    }
}
