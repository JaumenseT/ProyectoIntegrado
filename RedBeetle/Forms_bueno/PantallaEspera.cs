using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBeetle.Forms_bueno
{
	public partial class PantallaEspera : Form
	{
		public Action Proceso { get; set; }

		public PantallaEspera(Action proceso)
		{
			InitializeComponent();
			Proceso = proceso;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Task.Factory.StartNew(Proceso).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
		}
	}
}
