// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool GSourceFuncNative(IntPtr data);

	internal class GSourceFuncInvoker {

		GSourceFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~GSourceFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal GSourceFuncInvoker (GSourceFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal GSourceFuncInvoker (GSourceFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal GSourceFuncInvoker (GSourceFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.GSourceFunc Handler {
			get {
				return new GLib.GSourceFunc(InvokeNative);
			}
		}

		bool InvokeNative ()
		{
			bool __result = native_cb (__data);
			return __result;
		}
	}

	internal class GSourceFuncWrapper {

		public bool NativeCallback (IntPtr data)
		{
			try {
				bool __ret = managed ();
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal GSourceFuncNative NativeDelegate;
		GLib.GSourceFunc managed;

		public GSourceFuncWrapper (GLib.GSourceFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new GSourceFuncNative (NativeCallback);
		}

		public static GLib.GSourceFunc GetManagedDelegate (GSourceFuncNative native)
		{
			if (native == null)
				return null;
			GSourceFuncWrapper wrapper = (GSourceFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
