using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class RuinsVillage : MonoBehaviour
{
    //�����̼�
    [SerializeField]
    private NarationDialogSystem NdialogSystem05;
    [SerializeField]
    private NarationDialogSystem NdialogSystem06;
    [SerializeField]
    private NarationDialogSystem NdialogSystem07;
    [SerializeField]
    private NarationDialogSystem NdialogSystem08;

    //ĳ���� ���
    [SerializeField]
    private CharaterDialogSystem CdialogSystem04;
    [SerializeField]
    private CharaterDialogSystem CdialogSystem05;

    public GameObject SoundManager;

    private IEnumerator Start()
    {
        DelPreImage();
        
        yield return new WaitForSeconds(1);
        PadeStop();

        yield return new WaitUntil(() => NdialogSystem05.UpdateDialog());
        yield return new WaitUntil(() => NdialogSystem06.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem04.UpdateDialog());
        yield return new WaitUntil(() => NdialogSystem07.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem05.UpdateDialog());
        yield return new WaitUntil(() => NdialogSystem08.UpdateDialog());

        SoundManager.GetComponent<SoundManager>().StopBgm("LennaDie");
        SoundManager.GetComponent<SoundManager>().PlayBgm("RuinsVillageBgm");

        SceneManager.LoadScene("GameScene");
        

        
    }

    public void PadeStop() // PadeImage �۵� ����
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
    public void PadeStart() //PadeImage �۵�
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    public void DelPreImage() // ���� ��� ����
    {
        GameObject.Find("Canvas").transform.Find("Firevillage").gameObject.SetActive(false);
    }
    public void ItemSelect()
    {
        GameObject.Find("SelectItemCanvas").transform.Find("ItemSelect").gameObject.SetActive(true);
    }
    public void Blur()
    {
        GameObject.Find("Canvas").transform.Find("BlurImage").gameObject.SetActive(true);
    }
}
