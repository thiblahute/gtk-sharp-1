// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void TaskThreadFuncNative(IntPtr task, IntPtr source_object, IntPtr task_data, IntPtr cancellable);

	internal class TaskThreadFuncInvoker {

		TaskThreadFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TaskThreadFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TaskThreadFuncInvoker (TaskThreadFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TaskThreadFuncInvoker (TaskThreadFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TaskThreadFuncInvoker (TaskThreadFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.TaskThreadFunc Handler {
			get {
				return new GLib.TaskThreadFunc(InvokeNative);
			}
		}

		void InvokeNative (GLib.Task task, IntPtr source_object, IntPtr task_data, GLib.Cancellable cancellable)
		{
			native_cb (task == null ? IntPtr.Zero : task.Handle, source_object, __data, cancellable == null ? IntPtr.Zero : cancellable.Handle);
		}
	}

	internal class TaskThreadFuncWrapper {

		public void NativeCallback (IntPtr task, IntPtr source_object, IntPtr task_data, IntPtr cancellable)
		{
			try {
				managed (GLib.Object.GetObject(task) as GLib.Task, source_object, task_data, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal TaskThreadFuncNative NativeDelegate;
		GLib.TaskThreadFunc managed;

		public TaskThreadFuncWrapper (GLib.TaskThreadFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TaskThreadFuncNative (NativeCallback);
		}

		public static GLib.TaskThreadFunc GetManagedDelegate (TaskThreadFuncNative native)
		{
			if (native == null)
				return null;
			TaskThreadFuncWrapper wrapper = (TaskThreadFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
