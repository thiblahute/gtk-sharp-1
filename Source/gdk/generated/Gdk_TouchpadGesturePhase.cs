// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.TouchpadGesturePhaseGType))]
	public enum TouchpadGesturePhase {

		Begin,
		Update,
		End,
		Cancel,
	}

	internal class TouchpadGesturePhaseGType {
		[DllImport ("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_touchpad_gesture_phase_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_touchpad_gesture_phase_get_type ());
			}
		}
	}
#endregion
}
