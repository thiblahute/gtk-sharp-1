// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IConverter : GLib.IWrapper {

		GLib.ConverterResult Convert(IntPtr inbuf, ulong inbuf_size, IntPtr outbuf, ulong outbuf_size, GLib.ConverterFlags flags, out ulong bytes_read, out ulong bytes_written);
		void Reset();
	}

	[GLib.GInterface (typeof (ConverterAdapter))]
	public partial interface IConverterImplementor : GLib.IWrapper {

		GLib.ConverterResult Convert (IntPtr inbuf, ulong inbuf_size, IntPtr outbuf, ulong outbuf_size, GLib.ConverterFlags flags, out ulong bytes_read, out ulong bytes_written);
		void Reset ();
	}
#endregion
}
