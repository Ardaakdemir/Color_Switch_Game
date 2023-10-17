using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Hareket : MonoBehaviour
{
    public Rigidbody2D top;
    public float ziplamaGucu; 

    public Color SariRenk,MorRenk,MaviRenk,PembeRenk;
    public string MevcutRenk;
    public Transform Yukarial,Cember1,Cember2,Kare,Kontrol1,Kontrol2,Kontrol3;
    public SpriteRenderer ressam;

    public TextMeshProUGUI Score;
    public static int skor;

    public GameObject PuanSkor,Skore,Playbutton,Anikey,Anikey2,Baslik,ESC;

    public AudioSource zip;
    
    void Start() {
        Dondurme.donusHizi = 0.6f;
        RastgeleRenk();
        skor = 0;
        Time.timeScale = 0;
        Anikey.SetActive(true);
        PuanSkor.SetActive(false);
        Skore.SetActive(false);
        Playbutton.SetActive(true);
        Anikey2.SetActive(true); 
        Baslik.SetActive(true);    
        ESC.SetActive(true);   
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
        top.velocity = Vector2.up * ziplamaGucu;
        zip.Play();
        Score.text = "Score = "+skor;
        }
        if(Input.anyKeyDown)
        {
           Time.timeScale = 1;
           PuanSkor.SetActive(true);
        Skore.SetActive(true);
        Playbutton.SetActive(false);
        Anikey.SetActive(false);
        Anikey2.SetActive(false);
        Baslik.SetActive(false);    
        ESC.SetActive(false);   
        if(Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
        }
        }
        
    
}
    void RastgeleRenk(){

        int Rastgele = Random.Range(0,4);

        switch (Rastgele)
        {
            case 0:
            MevcutRenk="Sari";
            ressam.color = SariRenk;
            break;
            case 1:
            MevcutRenk="Mor";
            ressam.color = MorRenk;
            break;
            case 2:
            MevcutRenk="Mavi";
            ressam.color = MaviRenk;
            break;
            case 3:
            MevcutRenk="Pembe";
            ressam.color = PembeRenk;
            break;
        }
    }
    void OnTriggerEnter2D(Collider2D Temas) {

        if (Temas.tag != MevcutRenk && Temas.tag != "RenkDegistirici" && Temas.tag != "Kontrol1" &&  Temas.tag != "Kontrol2" && Temas.tag != "Kontrol3")
        {
            SceneManager.LoadScene("Restart");
        }
        if(Temas.tag == "RenkDegistirici")
        {
            RastgeleRenk();
            Yukarial.position = new Vector3(Yukarial.position.x,Yukarial.position.y + 9 ,Yukarial.position.z);
            skor ++;
            Dondurme.donusHizi += 0.1f;
        }
        if(Temas.tag == "Kontrol1")
        {
            Cember1.position = new Vector3(Cember1.position.x,Cember1.position.y + 27 ,Cember1.position.z);
            Kontrol1.position = new Vector3(Kontrol1.position.x,Kontrol1.position.y + 27 ,Kontrol1.position.z);
        }
        if(Temas.tag == "Kontrol2")
        {
            Cember2.position = new Vector3(Cember2.position.x,Cember2.position.y + 27 ,Cember2.position.z);
            Kontrol2.position = new Vector3(Kontrol2.position.x,Kontrol2.position.y + 27 ,Kontrol2.position.z);
        }
        if(Temas.tag == "Kontrol3")
        {
            Kare.position = new Vector3(Kare.position.x,Kare.position.y + 27 ,Kare.position.z);
            Kontrol3.position = new Vector3(Kontrol3.position.x,Kontrol3.position.y + 27 ,Kontrol3.position.z);
        }
           

    }

}