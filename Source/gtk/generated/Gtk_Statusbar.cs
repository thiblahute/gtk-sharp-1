// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Statusbar : Gtk.Box {

		public Statusbar (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_statusbar_new();

		public Statusbar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Statusbar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_statusbar_new();
		}

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get {
				GLib.Value val = GetProperty ("shadow-type");
				Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("text-popped")]
		public event Gtk.TextPoppedHandler TextPopped {
			add {
				this.AddSignalHandler ("text-popped", value, typeof (Gtk.TextPoppedArgs));
			}
			remove {
				this.RemoveSignalHandler ("text-popped", value);
			}
		}

		[GLib.Signal("text-pushed")]
		public event Gtk.TextPushedHandler TextPushed {
			add {
				this.AddSignalHandler ("text-pushed", value, typeof (Gtk.TextPushedArgs));
			}
			remove {
				this.RemoveSignalHandler ("text-pushed", value);
			}
		}

		static TextPushedNativeDelegate TextPushed_cb_delegate;
		static TextPushedNativeDelegate TextPushedVMCallback {
			get {
				if (TextPushed_cb_delegate == null)
					TextPushed_cb_delegate = new TextPushedNativeDelegate (TextPushed_cb);
				return TextPushed_cb_delegate;
			}
		}

		static void OverrideTextPushed (GLib.GType gtype)
		{
			OverrideTextPushed (gtype, TextPushedVMCallback);
		}

		static void OverrideTextPushed (GLib.GType gtype, TextPushedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("text_pushed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TextPushedNativeDelegate (IntPtr inst, uint context_id, IntPtr text);

		static void TextPushed_cb (IntPtr inst, uint context_id, IntPtr text)
		{
			try {
				Statusbar __obj = GLib.Object.GetObject (inst, false) as Statusbar;
				__obj.OnTextPushed (context_id, GLib.Marshaller.Utf8PtrToString (text));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Statusbar), ConnectionMethod="OverrideTextPushed")]
		protected virtual void OnTextPushed (uint context_id, string text)
		{
			InternalTextPushed (context_id, text);
		}

		private void InternalTextPushed (uint context_id, string text)
		{
			TextPushedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("text_pushed"));
				unmanaged = (TextPushedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TextPushedNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			unmanaged (this.Handle, context_id, native_text);
			GLib.Marshaller.Free (native_text);
		}

		static TextPoppedNativeDelegate TextPopped_cb_delegate;
		static TextPoppedNativeDelegate TextPoppedVMCallback {
			get {
				if (TextPopped_cb_delegate == null)
					TextPopped_cb_delegate = new TextPoppedNativeDelegate (TextPopped_cb);
				return TextPopped_cb_delegate;
			}
		}

		static void OverrideTextPopped (GLib.GType gtype)
		{
			OverrideTextPopped (gtype, TextPoppedVMCallback);
		}

		static void OverrideTextPopped (GLib.GType gtype, TextPoppedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("text_popped"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TextPoppedNativeDelegate (IntPtr inst, uint context_id, IntPtr text);

		static void TextPopped_cb (IntPtr inst, uint context_id, IntPtr text)
		{
			try {
				Statusbar __obj = GLib.Object.GetObject (inst, false) as Statusbar;
				__obj.OnTextPopped (context_id, GLib.Marshaller.Utf8PtrToString (text));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Statusbar), ConnectionMethod="OverrideTextPopped")]
		protected virtual void OnTextPopped (uint context_id, string text)
		{
			InternalTextPopped (context_id, text);
		}

		private void InternalTextPopped (uint context_id, string text)
		{
			TextPoppedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("text_popped"));
				unmanaged = (TextPoppedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TextPoppedNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			unmanaged (this.Handle, context_id, native_text);
			GLib.Marshaller.Free (native_text);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("reserved"
							, Gtk.Box.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // reserved
							, null
							, "text_pushed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("text_pushed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // text_pushed
							, "reserved"
							, "text_popped"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("text_popped"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // text_popped
							, "text_pushed"
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "text_popped"
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
		static extern uint gtk_statusbar_get_context_id(IntPtr raw, IntPtr context_description);

		public uint GetContextId(string context_description) {
			IntPtr native_context_description = GLib.Marshaller.StringToPtrGStrdup (context_description);
			uint raw_ret = gtk_statusbar_get_context_id(Handle, native_context_description);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_context_description);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_statusbar_get_message_area(IntPtr raw);

		public Gtk.Widget MessageArea { 
			get {
				IntPtr raw_ret = gtk_statusbar_get_message_area(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_statusbar_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_statusbar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_statusbar_pop(IntPtr raw, uint context_id);

		public void Pop(uint context_id) {
			gtk_statusbar_pop(Handle, context_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_statusbar_push(IntPtr raw, uint context_id, IntPtr text);

		public uint Push(uint context_id, string text) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			uint raw_ret = gtk_statusbar_push(Handle, context_id, native_text);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_text);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_statusbar_remove(IntPtr raw, uint context_id, uint message_id);

		public void Remove(uint context_id, uint message_id) {
			gtk_statusbar_remove(Handle, context_id, message_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_statusbar_remove_all(IntPtr raw, uint context_id);

		public void RemoveAll(uint context_id) {
			gtk_statusbar_remove_all(Handle, context_id);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Box.abi_info.Fields
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
