// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void GetChildPositionHandler(object o, GetChildPositionArgs args);

	public class GetChildPositionArgs : GLib.SignalArgs {
		public Gtk.Widget Widget{
			get {
				return (Gtk.Widget) Args [0];
			}
		}

		public Gdk.Rectangle Allocation{
			get {
				return (Gdk.Rectangle) Args [1];
			}
		}

	}
}
