// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void DisplayOpenedHandler(object o, DisplayOpenedArgs args);

	public class DisplayOpenedArgs : GLib.SignalArgs {
		public Gdk.Display Display{
			get {
				return (Gdk.Display) Args [0];
			}
		}

	}
}