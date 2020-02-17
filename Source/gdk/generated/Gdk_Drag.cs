// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Drag {

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_drag_abort(IntPtr context, uint time_);

		public static void Abort(Gdk.DragContext context, uint time_) {
			gdk_drag_abort(context == null ? IntPtr.Zero : context.Handle, time_);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_drag_begin_for_device(IntPtr window, IntPtr device, IntPtr targets);

		public static Gdk.DragContext BeginForDevice(Gdk.Window window, Gdk.Device device, GLib.List targets) {
			IntPtr raw_ret = gdk_drag_begin_for_device(window == null ? IntPtr.Zero : window.Handle, device == null ? IntPtr.Zero : device.Handle, targets == null ? IntPtr.Zero : targets.Handle);
			Gdk.DragContext ret = GLib.Object.GetObject(raw_ret) as Gdk.DragContext;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_drag_begin_from_point(IntPtr window, IntPtr device, IntPtr targets, int x_root, int y_root);

		public static Gdk.DragContext BeginFromPoint(Gdk.Window window, Gdk.Device device, GLib.List targets, int x_root, int y_root) {
			IntPtr raw_ret = gdk_drag_begin_from_point(window == null ? IntPtr.Zero : window.Handle, device == null ? IntPtr.Zero : device.Handle, targets == null ? IntPtr.Zero : targets.Handle, x_root, y_root);
			Gdk.DragContext ret = GLib.Object.GetObject(raw_ret) as Gdk.DragContext;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_drag_drop(IntPtr context, uint time_);

		public static void Drop(Gdk.DragContext context, uint time_) {
			gdk_drag_drop(context == null ? IntPtr.Zero : context.Handle, time_);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_drag_drop_done(IntPtr context, bool success);

		public static void DropDone(Gdk.DragContext context, bool success) {
			gdk_drag_drop_done(context == null ? IntPtr.Zero : context.Handle, success);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_drag_drop_succeeded(IntPtr context);

		public static bool DropSucceeded(Gdk.DragContext context) {
			bool raw_ret = gdk_drag_drop_succeeded(context == null ? IntPtr.Zero : context.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_drag_find_window_for_screen(IntPtr context, IntPtr drag_window, IntPtr screen, int x_root, int y_root, out IntPtr dest_window, out int protocol);

		public static void FindWindowForScreen(Gdk.DragContext context, Gdk.Window drag_window, Gdk.Screen screen, int x_root, int y_root, out Gdk.Window dest_window, out Gdk.DragProtocol protocol) {
			IntPtr native_dest_window;
			int native_protocol;
			gdk_drag_find_window_for_screen(context == null ? IntPtr.Zero : context.Handle, drag_window == null ? IntPtr.Zero : drag_window.Handle, screen == null ? IntPtr.Zero : screen.Handle, x_root, y_root, out native_dest_window, out native_protocol);
			dest_window = GLib.Object.GetObject(native_dest_window) as Gdk.Window;
			protocol = (Gdk.DragProtocol) native_protocol;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_drag_get_selection(IntPtr context);

		public static Gdk.Atom GetSelection(Gdk.DragContext context) {
			IntPtr raw_ret = gdk_drag_get_selection(context == null ? IntPtr.Zero : context.Handle);
			Gdk.Atom ret = raw_ret == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.Atom), false);
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_drag_motion(IntPtr context, IntPtr dest_window, int protocol, int x_root, int y_root, int suggested_action, int possible_actions, uint time_);

		public static bool Motion(Gdk.DragContext context, Gdk.Window dest_window, Gdk.DragProtocol protocol, int x_root, int y_root, Gdk.DragAction suggested_action, Gdk.DragAction possible_actions, uint time_) {
			bool raw_ret = gdk_drag_motion(context == null ? IntPtr.Zero : context.Handle, dest_window == null ? IntPtr.Zero : dest_window.Handle, (int) protocol, x_root, y_root, (int) suggested_action, (int) possible_actions, time_);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_drag_status(IntPtr context, int action, uint time_);

		public static void Status(Gdk.DragContext context, Gdk.DragAction action, uint time_) {
			gdk_drag_status(context == null ? IntPtr.Zero : context.Handle, (int) action, time_);
		}

#endregion
	}
}