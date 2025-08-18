using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : Singleton<LoadSceneManager>
{
   private int sceneIndex = 0;
   public int characterIndex = 0;
   protected override void Awake()
   {
      if (instance == null)
      {
         instance = this as LoadSceneManager;
         DontDestroyOnLoad(gameObject);
      }
      else
      {
         Destroy(gameObject);
      }

      
   }
   public void OnLoadScene()
   {
      sceneIndex++;
      SceneManager.LoadScene(1);
   }

   public void SetCharacterIndex(int index)
   {
      sceneIndex = index;
   }
}
