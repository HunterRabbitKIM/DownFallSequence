using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FireVillageMotion : MonoBehaviour
{
    //�����̼�
    [SerializeField]
    private NarationDialogSystem NdialogSystem03;
    [SerializeField]
    private NarationDialogSystem NdialogSystem04;
    
   
    //ĳ���ʹ�ȭ
    [SerializeField]
    private CharaterDialogSystem CdialogSystem01;
    [SerializeField]
    private CharaterDialogSystem CdialogSystem02;
    [SerializeField]
    private CharaterDialogSystem CdialogSystem03;

    public GameObject SoundManager;

    private IEnumerator Start()
    {
        DelPreImage();
        SoundManager.GetComponent<SoundManager>().PlayBgm("LennaDie");
        yield return new WaitForSeconds(1);
        PadeStop();
        
        //ù���� ��� �б� ����
        yield return new WaitUntil(() => NdialogSystem03.UpdateDialog());
        //�ι�° ��� �б� ����
        yield return new WaitUntil(() => CdialogSystem01.UpdateDialog());
        //����°...
        SoundManager.GetComponent<SoundManager>().PlaySound("Stone");
        yield return new WaitUntil(() => NdialogSystem04.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem02.UpdateDialog());

        SoundManager.GetComponent<SoundManager>().PlaySound("Pukjjik");
        
        yield return new WaitUntil(() => CdialogSystem03.UpdateDialog());
        

        

        PadeStart();
        yield return new WaitForSeconds(1f);
        NextPage();
    }
    public void PadeStop() // PadeImage �۵� ����
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
    public void DelPreImage() // ���� ��� ����
    {
        GameObject.Find("Canvas").transform.Find("BackgroundMotion").gameObject.SetActive(false);
    }
    public void NextPage() // ���� ��� ����
    {
        GameObject.Find("Canvas").transform.Find("RuinsVillage").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage �۵�
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    
}
