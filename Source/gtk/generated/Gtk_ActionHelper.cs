// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ActionHelper : GLib.Object, Gtk.IActionObserver {

		public ActionHelper (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_helper_new(IntPtr widget);

		public ActionHelper (Gtk.IActionable widget) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ActionHelper)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_action_helper_new(widget == null ? IntPtr.Zero : ((widget is GLib.Object) ? (widget as GLib.Object).Handle : (widget as Gtk.ActionableAdapter).Handle));
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_action_helper_get_enabled(IntPtr raw);

		[GLib.Property ("enabled")]
		public bool Enabled {
			get  {
				bool raw_ret = gtk_action_helper_get_enabled(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_action_helper_get_active(IntPtr raw);

		[GLib.Property ("active")]
		public bool Active {
			get  {
				bool raw_ret = gtk_action_helper_get_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[GLib.Property ("role")]
		public Gtk.ButtonRole Role {
			get {
				GLib.Value val = GetProperty ("role");
				Gtk.ButtonRole ret = (Gtk.ButtonRole) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_helper_activate(IntPtr raw);

		public void Activate() {
			gtk_action_helper_activate(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_helper_get_action_name(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_helper_set_action_name(IntPtr raw, IntPtr action_name);

		public string ActionName { 
			get {
				IntPtr raw_ret = gtk_action_helper_get_action_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_action_helper_set_action_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_helper_get_action_target_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_helper_set_action_target_value(IntPtr raw, IntPtr action_target);

		public GLib.Variant ActionTargetValue { 
			get {
				IntPtr raw_ret = gtk_action_helper_get_action_target_value(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
			set {
				gtk_action_helper_set_action_target_value(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_action_helper_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_action_helper_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_observer_action_added(IntPtr raw, IntPtr observable, IntPtr action_name, IntPtr parameter_type, bool enabled, IntPtr state);

		public void ActionAdded(Gtk.IActionObservable observable, string action_name, GLib.VariantType parameter_type, bool enabled, GLib.Variant state) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_added(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, parameter_type == null ? IntPtr.Zero : parameter_type.Handle, enabled, state == null ? IntPtr.Zero : state.Handle);
			GLib.Marshaller.Free (native_action_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_observer_action_enabled_changed(IntPtr raw, IntPtr observable, IntPtr action_name, bool enabled);

		public void ActionEnabledChanged(Gtk.IActionObservable observable, string action_name, bool enabled) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_enabled_changed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, enabled);
			GLib.Marshaller.Free (native_action_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_observer_action_removed(IntPtr raw, IntPtr observable, IntPtr action_name);

		public void ActionRemoved(Gtk.IActionObservable observable, string action_name) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_removed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name);
			GLib.Marshaller.Free (native_action_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_observer_action_state_changed(IntPtr raw, IntPtr observable, IntPtr action_name, IntPtr state);

		public void ActionStateChanged(Gtk.IActionObservable observable, string action_name, GLib.Variant state) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_state_changed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, state == null ? IntPtr.Zero : state.Handle);
			GLib.Marshaller.Free (native_action_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_action_observer_primary_accel_changed(IntPtr raw, IntPtr observable, IntPtr action_name, IntPtr action_and_target);

		public void PrimaryAccelChanged(Gtk.IActionObservable observable, string action_name, string action_and_target) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			IntPtr native_action_and_target = GLib.Marshaller.StringToPtrGStrdup (action_and_target);
			gtk_action_observer_primary_accel_changed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, native_action_and_target);
			GLib.Marshaller.Free (native_action_name);
			GLib.Marshaller.Free (native_action_and_target);
		}

#endregion
	}
}