
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_homem_aranha
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		Heroi hero = new Heroi();
		Inimigo vilao = new Inimigo();
		PictureBox pb2 	 = new PictureBox();
	
		void Button1Click(object sender, EventArgs e)
		{
			button1.Visible=false;
			
			pb2.Parent = this;
			pb2.Load("dia0.jpg");
			pb2.SizeMode=PictureBoxSizeMode.StretchImage;
			pb2.Width = this.Width;
			pb2.Height = this.Height;
			hero.Parent= pb2;
			vilao.Parent= pb2;
			vilao.timer1.Enabled=true;
			
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right) hero.Dir(pb2);
			if (e.KeyCode == Keys.Left) hero.Esq(pb2);
			if (e.KeyCode == Keys.Up) hero.cima(pb2);
			if (e.KeyCode == Keys.Down) hero.baixo(pb2);
			
			if (e.KeyCode == Keys.D) hero.Dir(pb2);
			if (e.KeyCode == Keys.A) hero.Esq(pb2);
			if (e.KeyCode == Keys.S) hero.baixo(pb2);
			if (e.KeyCode == Keys.W) hero.cima(pb2);
			
			if (e.KeyCode == Keys.Enter) Button1Click(this,null);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{

		}
	}
}
