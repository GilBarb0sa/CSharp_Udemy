﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMdi
{
	public partial class FormDois : Form
	{
		public FormDois(Form parent)
		{
			InitializeComponent();

			MdiParent = parent;
		}

		private void btnTres_Click(object sender, EventArgs e)
		{
			FormTres f = new FormTres(MdiParent);
			f.Show();
			Close();  //Fecha uma form e deixa aberta só a que é direcionada
		}
	}
}
