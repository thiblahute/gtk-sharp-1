// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.FileChooserActionGType))]
	public enum FileChooserAction {

		Open,
		Save,
		SelectFolder,
		CreateFolder,
	}

	internal class FileChooserActionGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_chooser_action_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_file_chooser_action_get_type ());
			}
		}
	}
#endregion
}
