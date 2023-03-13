using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Soal : MonoBehaviour
{
    public AudioClip sfxBenar;
    public int alas;
    public int tinggi;
    public float luas;
    public float keliling;
    public TMP_Text[] soal;
    public TMP_InputField[] jawaban;
    public Image[] gambar;
    // Start is called before the first frame update
    void Start()
    {
        setQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setQuestion(){
        alas = getRandomNumber();
        tinggi = getRandomNumber();

        soal[0].text = "Alas = " + alas.ToString();
        soal[1].text = "Tinggi = " + tinggi.ToString();
        
        luas = 0.5f * alas * tinggi;

        float c = Mathf.Sqrt(Mathf.Pow(alas, 2) + Mathf.Pow(tinggi, 2));
        keliling = alas + tinggi + c;
    }

    public void checkAnswerLuas(){
        gambar[0].gameObject.SetActive(false);
        gambar[1].gameObject.SetActive(false);
        if(float.Parse(jawaban[0].text) == luas){
            Debug.Log("Jawaban Luas Benar");
            gambar[0].gameObject.SetActive(true);
        }else{
            Debug.Log("Jawaban Luas Salah");
            gambar[1].gameObject.SetActive(true);
        }
    }

    public void checkAnswerKeliling(){
        gambar[2].gameObject.SetActive(false);
        gambar[3].gameObject.SetActive(false);
        if(float.Parse(jawaban[1].text) == keliling){
            Debug.Log("Jawaban Kel Benar");
            gambar[2].gameObject.SetActive(true);
        }else{
            Debug.Log("Jawaban Kel Salah");
            gambar[3].gameObject.SetActive(true);
        }
    }

    public int getRandomNumber(){
        return Random.Range(1, 20);
    }

    public void playSFX(){
        GetComponent<AudioSource>().PlayOneShot(sfxBenar);
    }
}
