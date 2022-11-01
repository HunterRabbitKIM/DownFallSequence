using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemUsedButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public int buttonID;
    private Item thisItem;

    public Tooltips tooltip;
    //private Vector2 position;

    UIManager uIManager;

    private void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    //HELPER FUNCTION to get the items on this button
    private Item GetThisItem()
    {
        for(int i = 0; i <GameManager.instance.items.Count; i++)
        {
            if(buttonID == i)
            {
                thisItem = GameManager.instance.items[i];
                
            }
        }

        return thisItem;
        
    }

    public void UsedButton()
    {
        SelectPopUp();
    }

    public void Use()
    {
        // switch문 사용(?) 코드와 UI를 만들고 불러오는 형식으로 만들자
        if (thisItem.Inherence == "Gold")
        {
            uIManager.gold += 500;
        }
    }

    public void Removed()
    {

        GameManager.instance.RemoveItem(GetThisItem());

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetThisItem();
        if(thisItem != null)
        {
            tooltip.ShowTooltip();
            tooltip.UpdateTooltipName(thisItem.itemName);
            tooltip.UpdateTooltip(thisItem.itemDes); //TODO System.text StringBuilder
            
            //RectTransformUtility.ScreenPointToLocalPointInRectangle(GameObject.Find("Canvas").transform as RectTransform, Input.mousePosition, null, out position);
            
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(thisItem != null)
        {
            tooltip.HideTooltip();
            tooltip.UpdateTooltipName("");
            tooltip.UpdateTooltip(""); //CLEAR
            
        }
        
    }

    public void SelectPopUp()
    {
        GameObject.Find("SelectItemCanvas").transform.Find("SelectPopUp").gameObject.SetActive(true);
    }
}
