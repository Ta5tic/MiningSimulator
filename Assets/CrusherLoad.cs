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
using System.Runtime.Serialization;

namespace DataIO
{

	public class CrusherLoad //: Crusher
	{
		public int LoadID;
		public string TimeStamp;
		public double CrusherInput;
		public int CrusherFines;
		public double CrFines;
		public double CrFinesFe;
		public double CrFinesSiO2;
		public double FinesFe;
		public double FinesSiO2;
		public double CrInputFe;
		public double CrLumpFe;
		public double CrInputSiO2;
		public double CrLumpSiO2;
		public double LumpFe;
		public double LumpSiO2;
		public int Lump;
		public double R1Fe;
		public double R1SiO2;
		public int R1Tonnes;
		public double R2Fe;
		public double R2SiO2;
		public int R2Tonnes;
		public double R3Fe;
		public double R3SiO2;
		public int R3Tonnes;
		public double W1Fe;
		public double W1SiO2;
		public int W1Tonnes;
		
		public CrusherLoad()
		{
			LoadID =0;
			TimeStamp = " ";
			CrusherInput=0.0;
			CrusherFines=0;
			CrFinesSiO2 =0.0;
			CrFinesFe=0.0;
			FinesFe=0.0;
			FinesSiO2=0.0;
			CrInputFe=0.0;
			CrInputSiO2=0.0;
			CrLumpSiO2=0.0;
			LumpFe=0.0;
			LumpSiO2=0.0;
			Lump=0;
			R1Fe = 0.0;
			R1SiO2 = 0.0;
			R1Tonnes = 0;
			R2Fe = 0.0;
			R2SiO2 = 0.0;
			R2Tonnes = 0;
			R3Fe = 0.0;
			R3SiO2 = 0.0;
			R3Tonnes = 0;
			W1Fe = 0.0;
			W1SiO2 = 0.0;
			W1Tonnes = 0;
		}
		
		public CrusherLoad(int lid, string time, double crinput, int crfines, double crfinessio2, double crfinesfe,double finesfe, double finessio2, double crinputfe, double crinputsio2, double crlumpfe, double crlumpsio2,double lumpfe, double lumpsio2, int lump, double r1fe, double r1sio2, int r1t, double r2fe, double r2sio2, int r2t, double r3fe, double r3sio2, int r3t, double w1fe, double w1sio2, int w1t)
		{
			LoadID =lid;
			TimeStamp = time;
			CrusherInput=crinput;
			CrusherFines=crfines;
			CrFinesSiO2 =crfinessio2;
			CrFinesFe=crfinesfe;
			FinesFe=finesfe;
			FinesSiO2=finessio2;
			CrInputFe=crinputfe;
			CrInputSiO2=crinputsio2;
			CrLumpFe=crlumpfe;
			CrLumpSiO2=crlumpsio2;
			LumpFe=lumpfe;
			LumpSiO2=lumpsio2;
			Lump=lump;
			R1Fe = r1fe;
			R1SiO2 = r1sio2;
			R1Tonnes = r1t;
			R2Fe = r2fe;
			R2SiO2 = r2sio2;
			R2Tonnes = r2t;
			R3Fe = r3fe;
			R3SiO2 = r3sio2;
			R3Tonnes = r3t;
			W1Fe = w1fe;
			W1SiO2 = w1sio2;
			W1Tonnes = w1t;
			
		}
		
		public CrusherLoad(int lid)
		{
			LoadID = lid;
		}

		//public CrusherLoad crushL = new CrusherLoad();
	}
}