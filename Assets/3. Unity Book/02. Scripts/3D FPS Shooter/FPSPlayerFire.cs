using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FPSPlayerFire : MonoBehaviour
{
    private enum WeaponMode{Normal, Sniper}
    private WeaponMode wMode;
    public GameObject[] eff_Flash;
    
    public GameObject firePosition;
    public GameObject bombFactory;
    public GameObject bulletEffect;
    private Animator anim;
    private ParticleSystem ps;

    public TextMeshProUGUI wModeText;

    public float throwPower = 15f;
    public int weaponPower = 5;

    private bool ZoomMode = false;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        ps = bulletEffect.GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (FPSGameManager.Instance.gState != FPSGameManager.GameState.Run)
            return;
        
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
        {
            if (anim.GetFloat("MoveMotion") == 0)
                anim.SetTrigger("Attack");

            StartCoroutine(ShootEffectOn(0.05f));
            
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitInfo =  new RaycastHit();

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy")) // Raycast를 Enemy가 맞은 경우
                {
                    EnemyFSM eFSM = hitInfo.transform.GetComponent<EnemyFSM>();
                    eFSM.HitEnemy(weaponPower);
                }
                else // Raycast를 맞은 대상이 Enemy가 아닌 경우
                {
                    bulletEffect.transform.position = hitInfo.point;
                    bulletEffect.transform.forward = hitInfo.normal;

                    ps.Play();
                }
            }
        }
        
        if (Input.GetMouseButtonDown(1)) // 마우스 오른쪽 버튼 클릭
        {
            switch (wMode)
            {
                case WeaponMode.Normal:
                    GameObject bomb = Instantiate(bombFactory);
                    bomb.transform.position = firePosition.transform.position;

                    Rigidbody rb = bomb.GetComponent<Rigidbody>();
                    rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
                    break;
                case WeaponMode.Sniper:
                    float fov = ZoomMode ? 60f : 15f; //결과를 담을 변수 = 조건? 참일 때 : 거짓일 때 
                    ZoomMode = false;
                    break;
                    
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wMode = WeaponMode.Normal;
            Camera.main.fieldOfView= 60f;
            
            wModeText.text = "Normal Mode";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wMode = WeaponMode.Sniper;

            wModeText.text = "Sniper Mode";
        }
    }

    IEnumerator ShootEffectOn(float duration)
    {
        GameObject flash = eff_Flash[Random.Range(0, eff_Flash.Length - 1)];

        if (flash == null) yield break;

        flash.SetActive(true);
        yield return new WaitForSeconds(duration);

        if (flash != null)
            flash.SetActive(false);
    }
}