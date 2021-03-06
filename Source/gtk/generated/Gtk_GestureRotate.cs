// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GestureRotate : Gtk.Gesture {

		public GestureRotate (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_rotate_new(IntPtr widget);

		public GestureRotate (Gtk.Widget widget) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GestureRotate)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (widget != null) {
					names.Add ("widget");
					vals.Add (new GLib.Value (widget));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_gesture_rotate_new(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[GLib.Signal("angle-changed")]
		public event Gtk.AngleChangedHandler AngleChanged {
			add {
				this.AddSignalHandler ("angle-changed", value, typeof (Gtk.AngleChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("angle-changed", value);
			}
		}

		static AngleChangedNativeDelegate AngleChanged_cb_delegate;
		static AngleChangedNativeDelegate AngleChangedVMCallback {
			get {
				if (AngleChanged_cb_delegate == null)
					AngleChanged_cb_delegate = new AngleChangedNativeDelegate (AngleChanged_cb);
				return AngleChanged_cb_delegate;
			}
		}

		static void OverrideAngleChanged (GLib.GType gtype)
		{
			OverrideAngleChanged (gtype, AngleChangedVMCallback);
		}

		static void OverrideAngleChanged (GLib.GType gtype, AngleChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("angle_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AngleChangedNativeDelegate (IntPtr inst, double angle, double delta);

		static void AngleChanged_cb (IntPtr inst, double angle, double delta)
		{
			try {
				GestureRotate __obj = GLib.Object.GetObject (inst, false) as GestureRotate;
				__obj.OnAngleChanged (angle, delta);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.GestureRotate), ConnectionMethod="OverrideAngleChanged")]
		protected virtual void OnAngleChanged (double angle, double delta)
		{
			InternalAngleChanged (angle, delta);
		}

		private void InternalAngleChanged (double angle, double delta)
		{
			AngleChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("angle_changed"));
				unmanaged = (AngleChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AngleChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, angle, delta);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_gesture_rotate_get_angle_delta(IntPtr raw);

		public double AngleDelta { 
			get {
				double raw_ret = gtk_gesture_rotate_get_angle_delta(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_rotate_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_gesture_rotate_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
