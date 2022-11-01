using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Materail : MonoBehaviour
{
    [SerializeField]
    private NarationDialogSystem dialogSystem01;
    [SerializeField]
    private NarationDialogSystem dialogSystem02;
    
    private Renderer rr;
    float vanishprogress = 1f;
    float shprogress = 0f;
    bool fireon = true;

    public GameObject SoundManager;

    private IEnumerator Start()
    {
        SoundManager.GetComponent<SoundManager>().PlayBgm("IntroHalfSad");
        rr = GetComponent<Renderer>();
        rr.material.shader = Shader.Find("MoonflowerCarnivore/Dissolve Edge");
        //첫번쨰 대사 분기 시작
        yield return new WaitUntil(() => dialogSystem01.UpdateDialog());

        //두번째 대사 분기 시작
        fireon = false;
        SoundManager.GetComponent<SoundManager>().StopBgm("IntroHalfSad");
        SoundManager.GetComponent<SoundManager>().PlayBgm("IntroHalfHappy");
        yield return new WaitUntil(() => dialogSystem02.UpdateDialog());

       

        PadeStart();
        SoundManager.GetComponent<SoundManager>().StopBgm("IntroHalfHappy");
        yield return new WaitForSeconds(1f);

        NextImage();
    }

    // Update is called once per frame
    void Update()
    {
        if(fireon==true)
        {
            vanishprogress = Mathf.MoveTowards(vanishprogress, 0f, Time.deltaTime * 0.045f);
            rr.material.SetFloat("_Progress", vanishprogress);
        }
        else
        {
            shprogress = Mathf.MoveTowards(shprogress, 1f, Time.deltaTime * 0.08f);
            rr.material.SetFloat("_Progress", shprogress);
        }

    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    public void NextImage() // 다음 배경 생성
    {
        GameObject.Find("Canvas").transform.Find("Firevillage").gameObject.SetActive(true);
    }
}
