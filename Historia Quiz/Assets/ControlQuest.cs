using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlQuest : MonoBehaviour
{
    [System.Serializable]
    public class Soal
    {
        [System.Serializable]
        public class ElementSoal
        {
            [TextArea]
            public string soal;

            public string[] jawabans; // 2 0

            public int jawabanBenar; // angka array dari jawabans yang merupakan jawaban benar == 0
        }

        public ElementSoal elementSoal;
    }
    // Start is called before the first frame update
    public List<Soal> soals;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
