// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void MoveHandleHandler(object o, MoveHandleArgs args);

	public class MoveHandleArgs : GLib.SignalArgs {
		public Gtk.ScrollType Scroll{
			get {
				return (Gtk.ScrollType) Args [0];
			}
		}

	}
}
