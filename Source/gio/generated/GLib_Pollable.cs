// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Pollable {

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_pollable_source_new(IntPtr pollable_stream);

		public static GLib.Source SourceNew(GLib.Object pollable_stream) {
			IntPtr raw_ret = g_pollable_source_new(pollable_stream == null ? IntPtr.Zero : pollable_stream.Handle);
			GLib.Source ret = new GLib.Source(raw_ret);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_pollable_source_new_full(IntPtr pollable_stream, IntPtr child_source, IntPtr cancellable);

		public static GLib.Source SourceNewFull(IntPtr pollable_stream, GLib.Source child_source, GLib.Cancellable cancellable) {
			IntPtr raw_ret = g_pollable_source_new_full(pollable_stream, child_source == null ? IntPtr.Zero : child_source.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle);
			GLib.Source ret = new GLib.Source(raw_ret);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_pollable_stream_read(IntPtr stream, IntPtr buffer, UIntPtr count, bool blocking, IntPtr cancellable, out IntPtr error);

		public static unsafe long StreamRead(GLib.InputStream stream, IntPtr buffer, ulong count, bool blocking, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_pollable_stream_read(stream == null ? IntPtr.Zero : stream.Handle, buffer, new UIntPtr (count), blocking, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_pollable_stream_write(IntPtr stream, IntPtr buffer, UIntPtr count, bool blocking, IntPtr cancellable, out IntPtr error);

		public static unsafe long StreamWrite(GLib.OutputStream stream, IntPtr buffer, ulong count, bool blocking, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_pollable_stream_write(stream == null ? IntPtr.Zero : stream.Handle, buffer, new UIntPtr (count), blocking, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_pollable_stream_write_all(IntPtr stream, IntPtr buffer, UIntPtr count, bool blocking, out UIntPtr bytes_written, IntPtr cancellable, out IntPtr error);

		public static unsafe bool StreamWriteAll(GLib.OutputStream stream, IntPtr buffer, ulong count, bool blocking, out ulong bytes_written, GLib.Cancellable cancellable) {
			UIntPtr native_bytes_written;
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_pollable_stream_write_all(stream == null ? IntPtr.Zero : stream.Handle, buffer, new UIntPtr (count), blocking, out native_bytes_written, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			bytes_written = (ulong) native_bytes_written;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}