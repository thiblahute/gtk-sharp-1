// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void BeginHandler(object o, BeginArgs args);

	public class BeginArgs : GLib.SignalArgs {
		public Gdk.EventSequence Sequence{
			get {
				return (Gdk.EventSequence) Args [0];
			}
		}

	}
}
