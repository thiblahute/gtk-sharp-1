// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.FullscreenModeGType))]
	public enum FullscreenMode {

		CurrentMonitor,
		AllMonitors,
	}

	internal class FullscreenModeGType {
		[DllImport ("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_fullscreen_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_fullscreen_mode_get_type ());
			}
		}
	}
#endregion
}
