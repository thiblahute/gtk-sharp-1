// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void UpdateCustomWidgetHandler(object o, UpdateCustomWidgetArgs args);

	public class UpdateCustomWidgetArgs : GLib.SignalArgs {
		public Gtk.Widget Widget{
			get {
				return (Gtk.Widget) Args [0];
			}
		}

		public Gtk.PageSetup Setup{
			get {
				return (Gtk.PageSetup) Args [1];
			}
		}

		public Gtk.PrintSettings Settings{
			get {
				return (Gtk.PrintSettings) Args [2];
			}
		}

	}
}
