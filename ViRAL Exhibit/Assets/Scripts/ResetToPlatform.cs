using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToPlatform : MonoBehaviour
{
    public Vector3 init_pos;
    public Vector3 init_rot;

    // Start is called before the first frame update
    void Start()
    {
        init_pos = transform.position;
        init_rot = transform.eulerAngles;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
      gameObject.GetComponentInChildren<Animator>().Play("Dissolve");
      yield return new WaitForSeconds(3);
      transform.position = init_pos;
      transform.eulerAngles = init_rot;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
