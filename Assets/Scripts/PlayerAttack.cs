using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform FirePosition;
    public Transform FirePositionLeft;
    public GameObject projectile;
    public GameObject egg;
    public Animator Animator;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            Instantiate(projectile, FirePosition.position, FirePosition.rotation);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Animator.SetTrigger("EggBombing");
            StartCoroutine(InstantiateEgg());
        }

    }
    IEnumerator InstantiateEgg()
    {
        yield return new WaitForSeconds(.8f);
        if(transform.localScale.x > 0)
        {
            Instantiate(egg, FirePosition.position, FirePosition.rotation);
        }
        else
        {
            Instantiate(egg, FirePositionLeft.position, FirePositionLeft.rotation);
        }
        // Instantiate(egg, FirePosition.position, FirePosition.rotation);
    }
}
