/* 
 *------------------------------------------------------------------------------
 *Author Zayd Bhyat
 *Version 1.03
 *File name: Scenario Manger
 *Purpose: Manages the scenarios expressed through the load studies
 *	Stores KPI'S in this class
 *	At the moment only stores data for without fines Lump result
 *	In future will store both scenario data
 *	
 *------------------------------------------------------------------------------
 */
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//namespace DataIO
//{
	public class ScenarioManager : MonoBehaviour
	{
		
		public class Scenario1 //: ScenarioManager //constructor
		{
			//Expresses fines results only
			public double DirectLoad;
			public int totalTruckKm;
			public double totalTruckCost;//in millions$
			public int totalFELTime;
			public double totalFELCost;//in millions$
			public double totalCRTime;
			public double totalCRCost;// in millions$
			public int tonnesProduct;
			public double totalValue;//in millions$
			public double gradePenalty;//in millions$
			public double totalCost;//in millions$
			public double netRevenue;//in millions$
			public double UMC;//in $/tonne
			
			public Scenario1()//Alternate Constructor
			{
				
				DirectLoad=0.0;
				tonnesProduct=0;
				totalValue=0.0;//in millions$
				totalCost=0.0;//in millions$
				netRevenue=0.0;//in millions$
				UMC=0.0;//in $/tonne
			}
			
			public Scenario1(double dl)//Debuging class
			{
				DirectLoad=dl;
			}
			
			public Scenario1(double dl,int ttkm, double ttc, int tft, double tfc,double tcrt, double tcrc, int tp, double tv, double gp, float tC, double nr, double unitmc)//default constructor
			{
				DirectLoad=dl;
				totalTruckKm=ttkm;
				totalTruckCost=ttc;//in millions$
				totalFELTime=tft;
				totalFELCost=tfc;//in millions$
				totalCRTime=tcrt;
				totalCRCost=tcrc;// in millions$
				tonnesProduct=tp;
				totalValue=tv;//in millions$
				gradePenalty=gp;//in millions$
				totalCost=tC;//in millions$
				netRevenue=nr;//in millions$
				UMC=unitmc;//in $/tonne
			}
		}
		
		
		public Scenario1 run1 = new Scenario1 ();
		public Scenario1 run2 = new Scenario1 ();
		public Scenario1 run3 = new Scenario1 ();
		public Scenario1 run4 = new Scenario1 ();
		public Scenario1 run5 = new Scenario1 ();
		void start()
		{

		}
	}
//}
