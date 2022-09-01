using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaguePreview : MonoBehaviour
{
    [SerializeField] private Animator anim;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPreview()
    {
        anim.SetFloat("speed", 1.0f);
        anim.Play("League", 1);
    }
    public void EndPreview()
    {
        anim.SetFloat("speed", -1.0f);
        anim.Play("League", 1);
    }
}
