using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
   [SerializeField] private float speed = 11f;
    float Xtrow;
    float Ytrow;


    [SerializeField] GameObject[] lasers;
    [SerializeField] ParticleSystem explosion;
    [SerializeField] private float pitchFuctX = 3f;
    [SerializeField] private float pitchFuctY = 2f;
    [SerializeField] private float controlPitchFactor = -15f;
    [SerializeField] private float controlPitchFactoryZ = 20f;
    public float xAngle, yAngle, zAngle;
    private MainManager manager;
    public Camera camera;
    public GameObject PYOO;
    private FireOfSaund FireOfSaund;


    public float Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        /* ParticleSystem ps = GetComponent<ParticleSystem>();
         var em = ps.emission;*/
        manager = GameObject.FindObjectOfType<MainManager>();
        camera = GameObject.FindObjectOfType<Camera>();
        FireOfSaund = GameObject.Find("fireSound").GetComponent<FireOfSaund>();
    }




    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        transformRotation();
        LaserControl();
        Neetro();

        

        if(CameraMove.Health > 0)
        {
            ExplosionOFF();
            
            
        }
        else
        {
            ExlosionON();
            manager.IsGameOver = true;
        }
        

    }

    private  void LaserControl()
    {
        if (Input.GetButton("Fire1")) 
        { 
            LaserActiv();

            FireOfSaund.SwitchON();

        } else
        {
            
            LaserDissapear();

            FireOfSaund.SwitchOFF();
        }
    }

  public void LaserActiv()
    {
        foreach (GameObject laser in lasers)
        {
            var EmmisionMod = laser.GetComponent<ParticleSystem>().emission;

            EmmisionMod.enabled = true;
            
        }
    }

   public void LaserDissapear()
    {
        foreach (GameObject laser in lasers)
        {
            var EmmisionMod = laser.GetComponent<ParticleSystem>().emission;
            EmmisionMod.enabled = false;
        }
    }

    void transformRotation()
    {
        float DuePitchPosition = transform.localPosition.y * pitchFuctX;
        float DuePitchControl = Ytrow * controlPitchFactor;

        float pitch = DuePitchPosition + DuePitchControl;
        float yaw = transform.localPosition.x * (-pitchFuctY);
        float roll = transform.localPosition.z +( -Xtrow )* controlPitchFactoryZ; 

        transform.localRotation = Quaternion.Euler(pitch,yaw,roll);
    }
    private void Move()
    {
        Xtrow = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Ytrow = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float nowPosX = transform.localPosition.x + Xtrow;
        float nowPosY = transform.localPosition.y + Ytrow;

        //Xtrow = Input.GetAxis("Horizontal");
        float MathPosX = Mathf.Clamp(nowPosX, -12f, +12f);
        float MathPosY = Mathf.Clamp(nowPosY, -6f, +9f);


        transform.localPosition = new Vector3(MathPosX, MathPosY, transform.localPosition.z);
    }

   void ExlosionON()
    {
        var Expl = explosion.GetComponent<ParticleSystem>().emission;
        Expl.enabled = true; // включаем эмиссию партикил систем
       

        explosion.Play(); // при потери жизней включается прогрывание партикл частиц

        GetComponent<MeshRenderer>().enabled = false;
        
    }

    void ExplosionOFF()
    {
        var Expl = explosion.GetComponent<ParticleSystem>().emission;
        Expl.enabled = false;

    }


    void Neetro()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            camera.fieldOfView = 140 ;
        }
        else { camera.fieldOfView = 70; }
    }

    
    

   
}
