// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.StyleContextPrintFlagsGType))]
	public enum StyleContextPrintFlags {

		None,
		Recurse = 1 << 0,
		ShowStyle = 1 << 1,
	}

	internal class StyleContextPrintFlagsGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_style_context_print_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_style_context_print_flags_get_type ());
			}
		}
	}
#endregion
}
