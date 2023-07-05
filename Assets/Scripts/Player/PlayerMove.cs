using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.position.x > LevelBOundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.position.x < LevelBOundary.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * 2, Space.World);





        }
        if (Input.GetKey(KeyCode.Space))
        {

            if (isJumping == false)
            {
                isJumping = true;
                playerObject.GetComponent<Animator>().Play("Jump");
                StartCoroutine(JumpSequence());
            }

        }

        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 5, Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -5, Space.World);
            }

        }

        IEnumerator JumpSequence()
        {

            yield return new WaitForSeconds(0.45f);
            comingDown = true;
            yield return new WaitForSeconds(0.45f);
            comingDown = false;
            isJumping = false;
            playerObject.GetComponent<Animator>().Play("Standard Run");

        }
    }
}
