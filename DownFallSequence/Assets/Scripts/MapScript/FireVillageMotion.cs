using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FireVillageMotion : MonoBehaviour
{
    //나레이션
    [SerializeField]
    private NarationDialogSystem NdialogSystem03;
    [SerializeField]
    private NarationDialogSystem NdialogSystem04;
    
   
    //캐릭터대화
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
        
        //첫번쨰 대사 분기 시작
        yield return new WaitUntil(() => NdialogSystem03.UpdateDialog());
        //두번째 대사 분기 시작
        yield return new WaitUntil(() => CdialogSystem01.UpdateDialog());
        //세번째...
        SoundManager.GetComponent<SoundManager>().PlaySound("Stone");
        yield return new WaitUntil(() => NdialogSystem04.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem02.UpdateDialog());

        SoundManager.GetComponent<SoundManager>().PlaySound("Pukjjik");
        
        yield return new WaitUntil(() => CdialogSystem03.UpdateDialog());
        

        

        PadeStart();
        yield return new WaitForSeconds(1f);
        NextPage();
    }
    public void PadeStop() // PadeImage 작동 해재
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
    public void DelPreImage() // 이전 배경 해재
    {
        GameObject.Find("Canvas").transform.Find("BackgroundMotion").gameObject.SetActive(false);
    }
    public void NextPage() // 다음 배경 생성
    {
        GameObject.Find("Canvas").transform.Find("RuinsVillage").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    
}
