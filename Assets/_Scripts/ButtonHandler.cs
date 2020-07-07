using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{

    public GameObject [] skinsPanel; // Skinleri tutan array.
    public GameObject[] skinsSourceImages; // Skinlerin source image lerini tutan array.
    public Sprite[] skinsPattern; // Skinlere ait image leri tutan array.
    
    int Rand;
    int previousRand = -1;
    bool unlockCompletedFlag;

    List<int> usedArray = new List<int>(); // Kullanilmis olan skin indexlerini tutacak array.

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        unlockCompletedFlag = true;

        // Eger 9 skin inde image leri acilmis ise if kosulunu saglamayacak ve tum skin lerin islemlerinin tamamlandigi anlasilacak.
        for (int i = 0; i < 9; i++)
        {
            if (usedArray.Contains(i) == false)
            {
                unlockCompletedFlag = false;
            }
        }

        // Tum islemler bittiyse butonu kitler ve islem gerceklestirilemez hale getirir.
        if(unlockCompletedFlag == true)
        {
            GetComponent<Button>().interactable = false;
        }
    }

    // Butona tiklaninca ratgele bir frame in icerigini gosterecek.
    public void changeFrame()
    {
        // Baslangicta tum skin lerin frame leri gri oluyor.
        for (int i = 0; i < 9; i++)
        {
            skinsPanel[i].GetComponent<Image>().color = new Color32(128, 128, 128, 255);
        }

        // 9 skin arasinda rastgele gezinme islemi
        for (int i = 0; i < 10; i++)
        {
                Invoke("ChangeColorFunc", i * 0.2f);
        }

        // Gezinme islemi sonrasinda son bulunan skin in image i acilir.
        Invoke("changeImageFunc", 2.2f);
    }

    void changeImageFunc()
    {
        // Ilgili skin in image i aktif edilir ve o skin in indexi kullanilmis skin indexlerini tutan array icerisine kaydedilir.
        skinsSourceImages[Rand].GetComponent<Image>().sprite = skinsPattern[Rand];
        usedArray.Add(Rand);

    }

    // 9 skin arasinda rastgele gezinip anlik olarak bulundugu skin in frame ine yesil gorunumu kazandiriliyor.
    void ChangeColorFunc()
    {
        // previousRand degiskenine onceden bir skin indexi atilmissa o skin in frame ini griye donduruyor.
        if (previousRand != -1)
        {
            skinsPanel[previousRand].GetComponent<Image>().color = new Color32(128, 128, 128, 255);
        }

        // 0-9 arasinda rastgele bir deger urettik.
        Rand = Random.Range(0, 9);

        // Kullanilmis indexler array inin icerisinden farkli bir sonuc elde edene kadar rastgele deger uret.
        while (usedArray.Contains(Rand))
        {
            Rand = Random.Range(0, 9);
        }

        // Kullanilmis index array i icerisinde olmadigina emin oldugumuz index e sahip skin in frame ini yesil hale getiriyor.
        skinsPanel[Rand].GetComponent<Image>().color = new Color32(41, 135, 45, 255);

        // Onceki deger kontrolu icin anlik degeri tutuyor.
        previousRand = Rand;
    }
}
