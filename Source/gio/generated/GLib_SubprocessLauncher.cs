// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SubprocessLauncher : GLib.Object {

		public SubprocessLauncher (IntPtr raw) : base(raw) {}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_subprocess_launcher_new(int flags);

		public SubprocessLauncher (GLib.SubprocessFlags flags) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SubprocessLauncher)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("flags");
				vals.Add (new GLib.Value (flags));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_subprocess_launcher_new((int) flags);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_subprocess_launcher_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_subprocess_launcher_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_subprocess_launcher_getenv(IntPtr raw, IntPtr variable);

		public string Getenv(string variable) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			IntPtr raw_ret = g_subprocess_launcher_getenv(Handle, native_variable);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_variable);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_set_child_setup(IntPtr raw, GLibSharp.SpawnChildSetupFuncNative child_setup, IntPtr user_data, GLib.DestroyNotify destroy_notify);

		public GLib.SpawnChildSetupFunc ChildSetup { 
			set {
				GLibSharp.SpawnChildSetupFuncWrapper value_wrapper = new GLibSharp.SpawnChildSetupFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy_notify;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy_notify = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy_notify = GLib.DestroyHelper.NotifyHandler;
				}
				g_subprocess_launcher_set_child_setup(Handle, value_wrapper.NativeDelegate, user_data, destroy_notify);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_set_cwd(IntPtr raw, IntPtr cwd);

		public string Cwd { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_cwd(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_set_environ(IntPtr raw, IntPtr env);

		public string Environ { 
			set {
				g_subprocess_launcher_set_environ(Handle, GLib.Marshaller.StringToPtrGStrdup(value));
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_set_stderr_file_path(IntPtr raw, IntPtr path);

		public string StderrFilePath { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_stderr_file_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_set_stdin_file_path(IntPtr raw, IntPtr path);

		public string StdinFilePath { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_stdin_file_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_set_stdout_file_path(IntPtr raw, IntPtr path);

		public string StdoutFilePath { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_subprocess_launcher_set_stdout_file_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_setenv(IntPtr raw, IntPtr variable, IntPtr value, bool overwrite);

		public void Setenv(string variable, string value, bool overwrite) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			g_subprocess_launcher_setenv(Handle, native_variable, native_value, overwrite);
			GLib.Marshaller.Free (native_variable);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_subprocess_launcher_spawnv(IntPtr raw, IntPtr argv, out IntPtr error);

		public unsafe GLib.Subprocess Spawnv(string argv) {
			IntPtr native_argv = GLib.Marshaller.StringToPtrGStrdup (argv);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_subprocess_launcher_spawnv(Handle, native_argv, out error);
			GLib.Subprocess ret = GLib.Object.GetObject(raw_ret) as GLib.Subprocess;
			GLib.Marshaller.Free (native_argv);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_take_fd(IntPtr raw, int source_fd, int target_fd);

		public void TakeFd(int source_fd, int target_fd) {
			g_subprocess_launcher_take_fd(Handle, source_fd, target_fd);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_take_stderr_fd(IntPtr raw, int fd);

		public void TakeStderrFd(int fd) {
			g_subprocess_launcher_take_stderr_fd(Handle, fd);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_take_stdin_fd(IntPtr raw, int fd);

		public void TakeStdinFd(int fd) {
			g_subprocess_launcher_take_stdin_fd(Handle, fd);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_take_stdout_fd(IntPtr raw, int fd);

		public void TakeStdoutFd(int fd) {
			g_subprocess_launcher_take_stdout_fd(Handle, fd);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_subprocess_launcher_unsetenv(IntPtr raw, IntPtr variable);

		public void Unsetenv(string variable) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			g_subprocess_launcher_unsetenv(Handle, native_variable);
			GLib.Marshaller.Free (native_variable);
		}

#endregion
	}
}
