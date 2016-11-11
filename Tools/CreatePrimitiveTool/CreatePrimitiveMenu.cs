using System;
using System.Collections;
using UnityEngine;
using UnityEngine.VR.Tools;

public class CreatePrimitiveMenu : MonoBehaviour
{
	[SerializeField]
	GameObject[] m_HighlightObjects;

	public Action<PrimitiveType, bool> selectPrimitive;

	public void CreatePrimitive(int type)
	{
		selectPrimitive((PrimitiveType)type, false);

		// the order of the objects in m_HighlightObjects is matched to the values of the PrimitiveType enum elements
		for (var i = 0; i < m_HighlightObjects.Length; i++)
		{
			var go = m_HighlightObjects[i];
			go.SetActive(i == type);
		}
	}

	public void CreateFreeformCube()
	{
		selectPrimitive(PrimitiveType.Cube, true);

		foreach (GameObject go in m_HighlightObjects)
			go.SetActive(false);
	}
}
