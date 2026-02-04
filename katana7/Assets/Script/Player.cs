using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public float jumpUp = 1;
    public Vector3 direction;

    Animator pAnimator;
    Rigidbody2D pRig2D;
    SpriteRenderer sp;

    void Start()
    {
        pAnimator = GetComponent<Animator>(); //애니메이터 컴포넌트 가져오기
        pRig2D = GetComponent<Rigidbody2D>(); //리지드바디2D 컴포넌트 가져오기
        sp = GetComponent<SpriteRenderer>(); //스프라이트렌더러 컴포넌트 가져오기
        direction = Vector2.zero; //방향 초기화
    }

    void KeyInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal"); // -1 0 1

        if(direction.x <0)
        {
            //left
            sp.flipX = true;
        }
        else if(direction.x >0)
        {
            //right
            sp.flipX = false;
        }
        else if(direction.x == 0)
        {

        }







    }




  
    void Update()
    {
        KeyInput();
    }
}
