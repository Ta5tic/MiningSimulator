/* 
 *------------------------------------------------------------------------------
 *Author Zayd Bhyat
 *Version 1.03
 *File name: 
 *Purpose: 
 *
 *	
 *	
 *------------------------------------------------------------------------------
 */
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace DataIO
{
	public class Crusher: MonoBehaviour
	{
		public int CrusherID;
		public int CrusherNumber;
		public double MaxCrushingRate;
		public double CrusherCost;
		//public CrusherLoad[] Loads; future implementation

		public Crusher()
		{
			CrusherID = 0;
			CrusherNumber = 0;
			MaxCrushingRate = 0.0;
			CrusherCost = 0.0;
		}
		
		public Crusher(int crid,int crnumber, double crrate, int crcost)
		{
			CrusherID = crid;
			CrusherNumber = crnumber;
			MaxCrushingRate = crrate;
			CrusherCost = crcost;
			
		}


	}
	

}
