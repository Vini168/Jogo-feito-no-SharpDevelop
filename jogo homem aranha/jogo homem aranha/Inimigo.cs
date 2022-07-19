
using System;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_homem_aranha
{
	
	public class Inimigo:Personagem
	{
		public Timer timer1 = new Timer();
		
		public Inimigo()
		{
			Load("kratos.gif");
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 240;
			Height = 240;
			Left = 500;
			Top = 120;
			timer1.Tick+=mover;
		}
		public void mover(object sender, EventArgs e)
		{
			Left -= speed;
			if(Left+Width<0)
			{
				Dispose();
				timer1.Enabled=false;
			}
		}
	}
}
