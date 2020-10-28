using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DataIO
{
	public class ReadDemo : MonoBehaviour 
	{
		
		public TextAsset csv;
		private ScenarioManager scenario1;
		//private Grapher2 r1CRT;
		string[,] grid;
		//string value="";
		
		void Start () 
		{
			scenario1 = GetComponent<ScenarioManager>();
			int index = 0;
			string output = "";
			//CSVReader.DebugOutputGrid(CSVReader.SplitCsvGrid(csv.text),index);
			grid=CSVReader.SplitCsvGrid (csv.text);
			scenario1.run1.DirectLoad=0.0;
			scenario1.run2.DirectLoad=0.25;
			scenario1.run3.DirectLoad=0.5;
			scenario1.run4.DirectLoad=0.75;
			scenario1.run5.DirectLoad=1.0;
			analyseString (grid,index,scenario1);
			//output = csv.text;
			Debug.Log (output);
			Debug.Log ("Run1 total truck KM's" + scenario1.run1.totalTruckKm);
			Debug.Log ("Run2 total truck KM's" + scenario1.run2.totalTruckKm); 
			Debug.Log ("Run1 total truck cost" + scenario1.run1.totalTruckCost);
			Debug.Log (scenario1.run1.totalFELTime);
			Debug.Log (scenario1.run1.totalFELCost);
			Debug.Log (scenario1.run4.totalCRTime);
		}
		
		/*analyse string and index
		 * if index == rage of key values, fill the scenario and appropriate DL run. 
		 */
		static private void analyseString(string[,] grid,int index,ScenarioManager scenario1)
		{
			string textBlock = "";
			for (int y = 0; y < grid.GetUpperBound(1); y++) 
			{	
				for (int x = 0; x < grid.GetUpperBound(0); x++) 
				{
					textBlock = grid[x,y];
					Debug.Log ("index check: "+index+" "+textBlock);
					if(index > 67 || index < 73)//total truck km
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index > 76 || index <82)//total
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index>85 || index <91)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index > 94 || index <100)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index > 103 || index < 109)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index>112 || index < 118)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index> 121 || index < 127)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index>130 || index< 135)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index > 139 || index < 145)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index >148 || index <154)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index>157 || index < 163)
					{
						fillScenario(textBlock,index,scenario1);
					}
					else if(index>166 || index< 172)
					{
						fillScenario(textBlock,index,scenario1);
					}
					//Debug.Log("An error has occured");
					index++;
				}
			}
			//Debug.Log(textOutput);
		}
		/* fill scenario
		 * use string and index to fill in the appropriate run and dl in the scenario
		 * 
		 */
		static private void fillScenario(string value,int index,ScenarioManager scenario1)
		{
			switch (index) 
			{
				//lump results
			case 68:
				scenario1.run1.totalTruckKm=int.Parse(value);
				break;
			case 69:
				scenario1.run2.totalTruckKm=int.Parse(value);
				break;
			case 70:
				scenario1.run3.totalTruckKm=int.Parse(value);
				break;
			case 71:
				scenario1.run4.totalTruckKm=int.Parse(value);
				break;
			case 72:
				scenario1.run5.totalTruckKm=int.Parse(value);
				break;
			case 77:
				scenario1.run1.totalTruckCost=double.Parse(value);
				break;
			case 78:
				scenario1.run2.totalTruckCost=double.Parse(value);
				break;
			case 79:
				scenario1.run3.totalTruckCost=double.Parse(value);
				break;
			case 80:
				scenario1.run4.totalTruckCost=double.Parse(value);
				break;
			case 81:
				scenario1.run5.totalTruckCost=double.Parse(value);
				break;
			case 86:
				scenario1.run1.totalFELTime=int.Parse(value);
				break;
			case 87:
				scenario1.run2.totalFELTime=int.Parse(value);
				break;
			case 88:
				scenario1.run3.totalFELTime=int.Parse(value);
				break;
			case 89:
				scenario1.run4.totalFELTime=int.Parse(value);
				break;
			case 90:
				scenario1.run5.totalFELTime=int.Parse(value);
				break;
			case 95:
				scenario1.run1.totalFELCost=double.Parse(value);
				break;
			case 96:
				scenario1.run2.totalFELCost=double.Parse(value);
				break;
			case 97:
				scenario1.run3.totalFELCost=double.Parse(value);
				break;
			case 98:
				scenario1.run4.totalFELCost=double.Parse(value);
				break;
			case 99:
				scenario1.run5.totalFELCost=double.Parse(value);
				break;
			case 104:
				scenario1.run1.totalCRTime=double.Parse(value);
				break;
			case 105:
				scenario1.run2.totalCRTime=double.Parse(value);
				break;
			case 106:
				scenario1.run3.totalCRTime=double.Parse(value);
				break;
			case 107:
				scenario1.run4.totalCRTime=double.Parse(value);
				break;
			case 108:
				scenario1.run5.totalCRTime=double.Parse(value);
				break;
			case 113:
				scenario1.run1.totalCRCost=double.Parse(value);
				break;
			case 114:
				scenario1.run2.totalCRCost=double.Parse(value);
				break;
			case 115:
				scenario1.run3.totalCRCost=double.Parse(value);
				break;
			case 116:
				scenario1.run4.totalCRCost=double.Parse(value);
				break;
			case 117:
				scenario1.run5.totalCRCost=double.Parse(value);
				break;
			case 122:
				scenario1.run1.tonnesProduct=int.Parse(value);
				break;
			case 123:
				scenario1.run2.tonnesProduct=int.Parse(value);
				break;
			case 124:
				scenario1.run3.tonnesProduct=int.Parse(value);
				break;
			case 125:
				scenario1.run4.tonnesProduct=int.Parse(value);
				break;
			case 126:
				scenario1.run5.tonnesProduct=int.Parse(value);
				break;
			case 131:
				scenario1.run1.totalValue=double.Parse(value);
				break;
			case 132:
				scenario1.run2.totalValue=double.Parse(value);
				break;
			case 133:
				scenario1.run3.totalValue=double.Parse(value);
				break;
			case 134:
				scenario1.run4.totalValue=double.Parse(value);
				break;
			case 135:
				scenario1.run5.totalValue=double.Parse(value);
				break;
			case 140:
				scenario1.run1.gradePenalty=double.Parse(value);
				break;
			case 141:
				scenario1.run2.gradePenalty=double.Parse(value);
				break;
			case 142:
				scenario1.run3.gradePenalty=double.Parse(value);
				break;
			case 143:
				scenario1.run4.gradePenalty=double.Parse(value);
				break;
			case 144:
				scenario1.run5.gradePenalty=double.Parse(value);
				break;
			case 149:
				scenario1.run1.totalCost=double.Parse(value);
				break;
			case 150:
				scenario1.run2.totalCost=double.Parse(value);
				break;
			case 151:
				scenario1.run3.totalCost=double.Parse(value);
				break;
			case 152:
				scenario1.run4.totalCost=double.Parse(value);
				break;
			case 153:
				scenario1.run5.totalCost=double.Parse(value);
				break;
			case 158:
				scenario1.run1.netRevenue=double.Parse(value);
				break;
			case 159:
				scenario1.run2.netRevenue=double.Parse(value);
				break;
			case 160:
				scenario1.run3.netRevenue=double.Parse(value);
				break;
			case 161:
				scenario1.run4.netRevenue=double.Parse(value);
				break;
			case 162:
				scenario1.run5.netRevenue=double.Parse(value);
				break;
			case 167:
				scenario1.run1.UMC=double.Parse(value);
				break;
			case 168:
				scenario1.run2.UMC=double.Parse(value);
				break;
			case 169:
				scenario1.run3.UMC=double.Parse(value);
				break;
			case 170:
				scenario1.run4.UMC=double.Parse(value);
				break;
			case 171:
				scenario1.run5.UMC=double.Parse(value);
				break;
				// Fine Results
				/*
				case 184:
				case 185:
				case 186:
					
				case 187:
					
				case 188:
					
				case 193:
				case 194:
				case 195:
				case 196:
				case 197:
				case 202:
				case 203:
				case 204:
				case 205:
				case 206:
				case 211:
				case 212:
				case 213:
				case 214:
				case 215:
				case 220:
				case 221:
				case 222:
				case 223:
				case 224:
				case 229:
				case 230:
				case 231:
				case 232:
				case 233:
				case 238:
				case 239:
				case 240:
				case 241:
				case 242:
				case 247:
				case 248:
				case 249:
				case 250:
				case 251:
				case 256:
				case 257:
				case 258:
				case 259:
				case 260:
				case 265:
				case 266:
				case 267:
				case 268:
				case 269:
				case 274:
				case 275:
				case 276:
				case 277:
				case 278:
				case 283:
				case 284:
				case 285:
				case 286:
				case 287:*/
			}
		}
		
	}
}