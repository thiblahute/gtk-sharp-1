// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RadioButton : Gtk.CheckButton {

		public RadioButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_radio_button_new_from_widget(IntPtr radio_group_member);

		public RadioButton (Gtk.RadioButton radio_group_member) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RadioButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (radio_group_member != null) {
					names.Add ("group");
					vals.Add (new GLib.Value (radio_group_member));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_radio_button_new_from_widget(radio_group_member == null ? IntPtr.Zero : radio_group_member.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_radio_button_new_with_mnemonic_from_widget(IntPtr radio_group_member, IntPtr label);

		public RadioButton (Gtk.RadioButton radio_group_member, string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RadioButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (radio_group_member != null) {
					names.Add ("group");
					vals.Add (new GLib.Value (radio_group_member));
				}
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_radio_button_new_with_mnemonic_from_widget(radio_group_member == null ? IntPtr.Zero : radio_group_member.Handle, native_label);
			GLib.Marshaller.Free (native_label);
		}

		[GLib.Signal("group-changed")]
		public event System.EventHandler GroupChanged {
			add {
				this.AddSignalHandler ("group-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("group-changed", value);
			}
		}

		static GroupChangedNativeDelegate GroupChanged_cb_delegate;
		static GroupChangedNativeDelegate GroupChangedVMCallback {
			get {
				if (GroupChanged_cb_delegate == null)
					GroupChanged_cb_delegate = new GroupChangedNativeDelegate (GroupChanged_cb);
				return GroupChanged_cb_delegate;
			}
		}

		static void OverrideGroupChanged (GLib.GType gtype)
		{
			OverrideGroupChanged (gtype, GroupChangedVMCallback);
		}

		static void OverrideGroupChanged (GLib.GType gtype, GroupChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("group_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GroupChangedNativeDelegate (IntPtr inst);

		static void GroupChanged_cb (IntPtr inst)
		{
			try {
				RadioButton __obj = GLib.Object.GetObject (inst, false) as RadioButton;
				__obj.OnGroupChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RadioButton), ConnectionMethod="OverrideGroupChanged")]
		protected virtual void OnGroupChanged ()
		{
			InternalGroupChanged ();
		}

		private void InternalGroupChanged ()
		{
			GroupChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("group_changed"));
				unmanaged = (GroupChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GroupChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("group_changed"
							, Gtk.CheckButton.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // group_changed
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "group_changed"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_radio_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_radio_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_radio_button_join_group(IntPtr raw, IntPtr group_source);

		public void JoinGroup(Gtk.RadioButton group_source) {
			gtk_radio_button_join_group(Handle, group_source == null ? IntPtr.Zero : group_source.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.CheckButton.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
