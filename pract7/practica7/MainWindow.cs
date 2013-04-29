using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int puntos = 0;

		if(this.Cuerpo.Active)

			puntos++;
		

		if(this.opc.Text=="4")
			puntos++;
		

		if(this.Mex.Active)
			puntos++;
		

		if(this.Arg.Active)
			puntos++;



		DateTime fecha= this.calendario.GetDate();
		string fechaSeleccionada = fecha.ToShortDateString();
		 if(fechaSeleccionada=="16/09/1810"){
			puntos++;

		}
		String nom = this.nombre.Text;
		String cod = this.codigo.Text;
		String Grupo = this.Grupo.ActiveText;
		
		MessageDialog md = new MessageDialog (null, 
		                                      DialogFlags.Modal,
		                                      MessageType.Info, 
		                                      ButtonsType.None, "Alumno: " + nom + 
		                                      "\nCodigo: " + cod +
		                                      "\nGrupo: " + Grupo +		                         
		                                      "\nTiene: " + puntos + "\npuntos de 5 posibles");
		md.Show();
	} 
	protected virtual void OnCmbGrupoChanged (object sender, System.EventArgs e)
	{
		MessageDialog md = new MessageDialog (null, 
		                                      DialogFlags.Modal,
		                                      MessageType.Info, 
		                                      ButtonsType.None, "Grupo: " + this.Grupo.ActiveText );
		md.Show();
	}
}
