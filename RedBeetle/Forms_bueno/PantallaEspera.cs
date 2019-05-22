using System;
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
            //Task.Run(Proceso).Wait();
            //this.Close();
			Task.Factory.StartNew(Proceso).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
		}
	}
}
