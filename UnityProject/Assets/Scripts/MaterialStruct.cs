﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialStruct {

    public string m_name;
    public string m_hexCol;
    public Color m_colour;


    // Use this for initialization
    public MaterialStruct(
        string name,
        string hexCol,
        Color colour              
        )
    {
        m_name = name;
        m_hexCol = hexCol;
        m_colour = colour;		
	}
}