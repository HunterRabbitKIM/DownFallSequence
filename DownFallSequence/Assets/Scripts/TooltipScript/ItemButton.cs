using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ItemButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    
    [SerializeField]
    private Tooltips tooltip;
    public Item itemData;


    public void OnPointerClick(PointerEventData eventData)
    {
        if(GameManager.instance.items.Count<GameManager.instance.slots.Length)
        {
            GameManager.instance.AddItem(itemData);
            ItemSelect();
            
        }
        else
        {
            Debug.Log("Full!!!!");
        }
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltip.ShowTooltip();
        tooltip.UpdateTooltipName(itemData.itemName);
        tooltip.UpdateTooltip(itemData.itemDes); //TODO System.text StringBuilder

        //RectTransformUtility.ScreenPointToLocalPointInRectangle(GameObject.Find("Canvas").transform as RectTransform, Input.mousePosition, null, out position);
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.HideTooltip();
        tooltip.UpdateTooltipName("");
        tooltip.UpdateTooltip(""); //CLEAR
    }
    public void ItemSelect()
    {
        GameObject.Find("SelectItemCanvas").transform.Find("ItemSelect").gameObject.SetActive(false);
        tooltip.HideTooltip();
    }
}
