using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutDoor : MonoBehaviour
{
	// ** 언제나 바깥에서는 이 정도의 타일이 깔려 있음. 
	private int tilePad = 4;
    private GameObject SaladTile;
	public GameObject TileFolder;

	private void Start()
	{
		SaladTile = Resources.Load("Prefabs/Tiles/SaladTile") as GameObject;
		Tiling();
	}

    private void Tiling()
	{
		for (int x = -tilePad; x <= tilePad; ++x)
		{
			for (int z = -tilePad; z <= tilePad; ++z)
			{
				GameObject tile = Instantiate(SaladTile);
				tile.transform.position = new Vector3(x, 0, z);
				tile.transform.SetParent(TileFolder.transform);
			}
		}
	}
}
