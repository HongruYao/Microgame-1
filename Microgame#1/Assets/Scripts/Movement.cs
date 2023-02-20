using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D Rigidbody;

    public EgamMicrogameInstance microgameInstance;
    public EgamMicrogameHelper egamMicrogameHelper;
    public float Speed;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();      
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement= new Vector2();

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();
        Rigidbody.velocity = movement * Speed;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trophy")
        {
            SoundManagerScript.Playsound("win");
            egamMicrogameHelper.instance._timeoutType = EgamMicrogameHelper.WinLose.Win;
            egamMicrogameHelper.instance._duration = 0;
            

        }
        else if (collision.tag == "Spikes")
        {
            SoundManagerScript.Playsound("lose");
            Destroy(gameObject);
            egamMicrogameHelper.instance._timeoutType = EgamMicrogameHelper.WinLose.Lose;
            egamMicrogameHelper.instance._duration = 0;
            
        }
    }
    public void OnWinCondition()
    {
        microgameInstance.WinGame();
    }
}
