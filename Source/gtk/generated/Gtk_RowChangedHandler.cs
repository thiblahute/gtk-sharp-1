// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void RowChangedHandler(object o, RowChangedArgs args);

	public class RowChangedArgs : GLib.SignalArgs {
		public Gtk.TreePath Path{
			get {
				return (Gtk.TreePath) Args [0];
			}
		}

		public Gtk.TreeIter Iter{
			get {
				return (Gtk.TreeIter) Args [1];
			}
		}

	}
}
