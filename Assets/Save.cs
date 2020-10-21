using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[System.Serializable]
public class Save
{
  //FIX ME NOT SURE OF linePrefab
  GameObject origLine = linePrefab;
  GameObject newLine = Instantiate(origLine);

  LineRenderer origLineComponent = origLine.GetComponent<LineRenderer>();
  float length = origLineComponent.positionCount;
  Vector3[] newPos = new Vector3[length];

  // FIX ME: number of lines
  int numLines = ;
  List<Vector3> savedPoints = new List<Vector3>(numLines);
  List<Color> colors = new List<Color>(numLines);
  List<string> textures = new List<string>(numLines);
  List<float> sizes = new List<float>(numLines);
  List<float> opacities = new List<float>(numLines);


}
