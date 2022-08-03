using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class UpdateReader : MonoBehaviour
{


            public TextAsset textFile;     // drop your file here in inspector

    void Start()
    {
        string text = textFile.text;  //this is the content as string
        byte[] byteText = textFile.bytes;  //this is the content as byte array
    }
}


