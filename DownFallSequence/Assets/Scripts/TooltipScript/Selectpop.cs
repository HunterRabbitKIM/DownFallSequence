using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectpop : MonoBehaviour
{
    public ItemUsedButton itemUsedButton;
    
    public void Pick()
    {
        SelectPopUp();
        itemUsedButton.Use();
        itemUsedButton.Removed();
    }

    public void Cancel()
    {
        SelectPopUp();
    }

    public void SelectPopUp()
    {
        GameObject.Find("SelectItemCanvas").transform.Find("SelectPopUp").gameObject.SetActive(false);
    }
}
