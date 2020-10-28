using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DataIO
{

	public class ReadRun : MonoBehaviour {
	
		public TextAsset csv;

		string[,] grid;
		//public Crusher crusher1;
		public CrusherLoad[] loads;
		// Use this for initialization
		void Start () 
		{
			grid = CSVReader.SplitCsvGrid (csv.text);
			loads = new CrusherLoad[200];
			analyseString (grid,loads);
			Debug.Log(loads[0].TimeStamp);
			Debug.Log (loads [0].LoadID);
		}
		private static void analyseString(string[,] grid, CrusherLoad[] l)
		{
			string textBlock = "";//text block
			string fullblock = "";
			int index = 0;//overall index of csv file
			int colValue=0;// coloumn value 0-25 resets at 25
			int rowNo = 0;// rowNo 1 - 200(59,580)

			for (int y = 0; y < grid.GetUpperBound(1); y++) 
			{	
				for (int x = 0; x < grid.GetUpperBound(0); x++) 
				{
					textBlock = grid[x,y];
					if (index >52)//bypass arbritary values
					{
						if (colValue > 25)
						{
							colValue=0;
							rowNo++;
						}
						if (textBlock == "")//check for blank spaces
							colValue++;
						else
						{

							if(colValue == 0)//0 ID and TimeStamp
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo]=new CrusherLoad();//create the object at row
								l[rowNo].LoadID = rowNo;
								l[rowNo].TimeStamp=textBlock;//Fill TimeStamp
							}
							else if(colValue == 1)//1 Crusher fines
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].CrusherFines = int.Parse(textBlock);
							}
							else if(colValue == 2)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].CrFinesFe =  double.Parse(textBlock);

							}	
								
							else if(colValue == 3)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].CrFinesSiO2 = double.Parse(textBlock);

							}	
								
							else if(colValue == 4)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
//								l[rowNo].CrusherInput = int.Parse(textBlock);

							}	
					
							else if(colValue == 5)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].CrInputFe = double.Parse(textBlock);

							}
							else if(colValue == 6)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].CrInputSiO2 = double.Parse(textBlock);

							}
			
							else if(colValue == 7)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].Lump = int.Parse(textBlock);

							}	
							else if(colValue == 8)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].CrLumpFe = double.Parse(textBlock);

							}
				
							else if(colValue == 9)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].CrLumpSiO2 = double.Parse(textBlock);

							}	
							else if(colValue == 10)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].FinesFe = double.Parse(textBlock);

							}	
							else if(colValue == 11)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].FinesSiO2 = double.Parse(textBlock);

							}

							else if(colValue == 12)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].LumpFe = double.Parse(textBlock);

								
							}	
							else if(colValue == 13)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].LumpSiO2 = double.Parse(textBlock);

								
							}	
							else if(colValue ==14)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								//l[rowNo].Lump = int.Parse(textBlock);

							}
							else if(colValue == 15)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].R1Fe =double.Parse(textBlock);

							}									
							else if(colValue == 16)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].R1SiO2 = double.Parse(textBlock);

							}
							else if(colValue == 17)
							{  
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
//								l[rowNo].R1Tonnes = int.Parse(textBlock);

							}
							 else if(colValue == 18)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].R2Fe=double.Parse(textBlock);

							}	
								
							 else if(colValue == 19)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].R2SiO2=double.Parse(textBlock);

								
							}	
							else if(colValue == 20)
							{	
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								//l[rowNo].R2Tonnes=int.Parse(textBlock);

							}	
								
							else if(colValue == 21)
							{	
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].R3Fe=double.Parse(textBlock);

								
							}	
							else if(colValue == 22)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].R3SiO2=double.Parse(textBlock);

							}	
								
							else if(colValue == 23)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].R3Tonnes=int.Parse(textBlock);

							}	
								
							else if(colValue == 24)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].W1Fe=double.Parse(textBlock);

							}
							else if(colValue == 25)
							{
								Debug.Log ("Row No:"+rowNo+" colNo:"+colValue+" String:"+textBlock);
								l[rowNo].W1SiO2=double.Parse(textBlock);

							}
							else
							{
								Debug.Log("invalid coloumn value");
							}


							colValue ++;
						}
					}

					fullblock += grid[x,y];
					//Debug.Log("index check:"+index+" "+textBlock);
					index ++;
				}
			}
			Debug.Log (fullblock);
		}
	}
}