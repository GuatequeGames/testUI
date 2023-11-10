using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] private bool UIBlocked;
    [SerializeField] private string nextScene;
    [SerializeField] private Animator anim;

    public static MenuManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }


    public void SetNextScene(string _scene)
    {
        nextScene = _scene;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
    public void SetUIBlocked(bool _blocked)
    {
        UIBlocked = _blocked;
    }

    public void LockUI()
    {
        UIBlocked = true;
    }

    public void UnlockUI()
    {
        UIBlocked = false;
    }
    public bool GetUIBlocked()
    {
        return UIBlocked;
    }



    public void ExitAnimation()
    {
        anim.SetTrigger("Exit");
    }

}
