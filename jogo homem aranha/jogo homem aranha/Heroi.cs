
using System;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_homem_aranha
{
	
	public class Heroi:Personagem
	{
		public Heroi()
		{
			Load("goku.gif");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width=130;
			Height = 130;
			Left = 0;
			Top = 190;
			
		}
		int contfundo=0, contUP=0;
		
		public void Dir(PictureBox pb2)
		{
			Left += speed;
			if (Left>500)
			{
				contfundo++;
				Left=0;
				if(contfundo == 2)
					contfundo = 0;
				
				pb2.Load("dia"+contfundo+".jpg");
			}
		}
		public void Esq (PictureBox pb2)
		 {
		 	 Left -= speed;
		 	 if (Left<0)
		 	 	Left = 0;
		 }
		public void cima (PictureBox pb2)
		 {
		 	Top -= speed;
			if (Top <=0)
			{
				if (contUP==0)
				{
					contUP++;
					pb2.Load("sky.jpg");
				Top = 250;
				}
				else
				{
				Top = 0;	
				}
			
			}
		}
		public void baixo (PictureBox pb2)
		 {
		 	     Top += speed;
			if (Top > 300)
			{ 
				if (contUP ==1)
				
					{
						contUP=0;
						pb2.Load("dia"+contfundo+".jpg");
						Top = 0;
					}
					else
						Top = 250;
						Left = 0;
			}
		  }
	}
}
