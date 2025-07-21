using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FPSPlayerMove : MonoBehaviour
{
    private CharacterController cc;
    
    public float moveSpeed = 7f;
    
    private float gravity = -20f;
    private float yVelocity = 0f;
    
    public float jumpPower = 10f;
    public bool isJumping = false;

    public int hp = 20;
    
    private int maxHp = 20;
    public Slider hpSlider;

    public GameObject hitEffect;

    public float JumpPower
    {
        get => jumpPower;
        set => jumpPower = value;
    }

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        if(FPSGameManager.Instance.gState != FPSGameManager.GameState.Run)
            return;
        
        float h =  Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v); //크기와 방향이 있는 벡터
        dir.Normalize(); //방향만 있는 벡터
        
        //카메라 기준 방향으로 변경
        dir = Camera.main.transform.TransformDirection(dir);
        
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;
        
        cc.Move(dir * moveSpeed * Time.deltaTime); // 캐릭터 컨트롤러에 내장된 기능 

        if (cc.collisionFlags == CollisionFlags.Below) // None : 아무것도 닿지 않은 상태, Sides : 옆면에 닿은 상태, Above : 머리에 닿은 상태, Below : 아래쪽에 닿은 상태
        {
            if (isJumping)
                isJumping = false;
            
            yVelocity = 0f;
        }

        if (Input.GetButtonDown("Jump")&& !isJumping)
        {
            isJumping = true;
            yVelocity = jumpPower;
        }
        hpSlider.value = (float)hp / (float)maxHp;
    }

    public void DamageAction(int damage)
    {
        hp -= damage;
        
        hpSlider.value = (float)hp / (float)maxHp;

        if (hp > 0)
        {
            StartCoroutine(PlayerHitEffect());
        }
    }

    IEnumerator PlayerHitEffect()
    {
        hitEffect.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        hitEffect.SetActive(false);
    }
}
