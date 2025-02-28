using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject VersionCanva;

    void Start(){
        VersionCanva.SetActive(false);
    }
   public void PlayGame(){
        SceneManager.LoadScene("MainGame");
   }
   public void QuitGame(){
        Application.Quit();
   }
   public void ShowVersionDetails(){
        VersionCanva.SetActive(true);
   }
   public void HideVersionDetails(){
        VersionCanva.SetActive(false);
   }
}
