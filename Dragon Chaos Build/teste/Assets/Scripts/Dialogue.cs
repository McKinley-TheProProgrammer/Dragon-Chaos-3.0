﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {


    public string nome;
    [TextArea(4, 10)]
    public string[,] sentencas = new string[2, 2] { { "Morgana", "a" },{ "a", "a" }};
   
	
}
