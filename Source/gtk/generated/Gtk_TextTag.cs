// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TextTag : GLib.Object {

		public TextTag (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_tag_new(IntPtr name);

		public TextTag (string name) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TextTag)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gtk_text_tag_new(native_name);
			GLib.Marshaller.Free (native_name);
		}

		[GLib.Property ("name")]
		public string Name {
			get {
				GLib.Value val = GetProperty ("name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("background")]
		public string Background {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background-gdk")]
		public Gdk.Color BackgroundGdk {
			get {
				GLib.Value val = GetProperty ("background-gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("background-gdk", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background-rgba")]
		public Gdk.RGBA BackgroundRgba {
			get {
				GLib.Value val = GetProperty ("background-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background-rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background-full-height")]
		public bool BackgroundFullHeight {
			get {
				GLib.Value val = GetProperty ("background-full-height");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background-full-height", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground")]
		public string Foreground {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("foreground", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground-gdk")]
		public Gdk.Color ForegroundGdk {
			get {
				GLib.Value val = GetProperty ("foreground-gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("foreground-gdk", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground-rgba")]
		public Gdk.RGBA ForegroundRgba {
			get {
				GLib.Value val = GetProperty ("foreground-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("foreground-rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("direction")]
		public Gtk.TextDirection Direction {
			get {
				GLib.Value val = GetProperty ("direction");
				Gtk.TextDirection ret = (Gtk.TextDirection) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("direction", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("editable")]
		public bool Editable {
			get {
				GLib.Value val = GetProperty ("editable");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("editable", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("font")]
		public string Font {
			get {
				GLib.Value val = GetProperty ("font");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("font-desc")]
		public Pango.FontDescription FontDesc {
			get {
				GLib.Value val = GetProperty ("font-desc");
				Pango.FontDescription ret = (Pango.FontDescription) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value, "PangoFontDescription");
				SetProperty("font-desc", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("family")]
		public string Family {
			get {
				GLib.Value val = GetProperty ("family");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("family", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("style")]
		public Pango.Style Style {
			get {
				GLib.Value val = GetProperty ("style");
				Pango.Style ret = (Pango.Style) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("style", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("variant")]
		public Pango.Variant Variant {
			get {
				GLib.Value val = GetProperty ("variant");
				Pango.Variant ret = (Pango.Variant) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("variant", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("stretch")]
		public Pango.Stretch Stretch {
			get {
				GLib.Value val = GetProperty ("stretch");
				Pango.Stretch ret = (Pango.Stretch) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("stretch", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size")]
		public int Size {
			get {
				GLib.Value val = GetProperty ("size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("scale")]
		public double Scale {
			get {
				GLib.Value val = GetProperty ("scale");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("scale", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size-points")]
		public double SizePoints {
			get {
				GLib.Value val = GetProperty ("size-points");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size-points", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("justification")]
		public Gtk.Justification Justification {
			get {
				GLib.Value val = GetProperty ("justification");
				Gtk.Justification ret = (Gtk.Justification) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("justification", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("language")]
		public string Language {
			get {
				GLib.Value val = GetProperty ("language");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("language", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("left-margin")]
		public int LeftMargin {
			get {
				GLib.Value val = GetProperty ("left-margin");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("left-margin", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("right-margin")]
		public int RightMargin {
			get {
				GLib.Value val = GetProperty ("right-margin");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("right-margin", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("indent")]
		public int Indent {
			get {
				GLib.Value val = GetProperty ("indent");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("indent", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("rise")]
		public int Rise {
			get {
				GLib.Value val = GetProperty ("rise");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("rise", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pixels-above-lines")]
		public int PixelsAboveLines {
			get {
				GLib.Value val = GetProperty ("pixels-above-lines");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pixels-above-lines", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pixels-below-lines")]
		public int PixelsBelowLines {
			get {
				GLib.Value val = GetProperty ("pixels-below-lines");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pixels-below-lines", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pixels-inside-wrap")]
		public int PixelsInsideWrap {
			get {
				GLib.Value val = GetProperty ("pixels-inside-wrap");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pixels-inside-wrap", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("strikethrough")]
		public bool Strikethrough {
			get {
				GLib.Value val = GetProperty ("strikethrough");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("strikethrough", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("underline")]
		public Pango.Underline Underline {
			get {
				GLib.Value val = GetProperty ("underline");
				Pango.Underline ret = (Pango.Underline) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("underline", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("underline-rgba")]
		public Gdk.RGBA UnderlineRgba {
			get {
				GLib.Value val = GetProperty ("underline-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("underline-rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("strikethrough-rgba")]
		public Gdk.RGBA StrikethroughRgba {
			get {
				GLib.Value val = GetProperty ("strikethrough-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("strikethrough-rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("wrap-mode")]
		public Gtk.WrapMode WrapMode {
			get {
				GLib.Value val = GetProperty ("wrap-mode");
				Gtk.WrapMode ret = (Gtk.WrapMode) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("wrap-mode", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("tabs")]
		public Pango.TabArray Tabs {
			get {
				GLib.Value val = GetProperty ("tabs");
				Pango.TabArray ret = (Pango.TabArray) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value, "PangoTabArray");
				SetProperty("tabs", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("invisible")]
		public bool Invisible {
			get {
				GLib.Value val = GetProperty ("invisible");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("invisible", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("paragraph-background")]
		public string ParagraphBackground {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("paragraph-background", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("paragraph-background-gdk")]
		public Gdk.Color ParagraphBackgroundGdk {
			get {
				GLib.Value val = GetProperty ("paragraph-background-gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("paragraph-background-gdk", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("paragraph-background-rgba")]
		public Gdk.RGBA ParagraphBackgroundRgba {
			get {
				GLib.Value val = GetProperty ("paragraph-background-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("paragraph-background-rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("fallback")]
		public bool Fallback {
			get {
				GLib.Value val = GetProperty ("fallback");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("fallback", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("letter-spacing")]
		public int LetterSpacing {
			get {
				GLib.Value val = GetProperty ("letter-spacing");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("letter-spacing", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("font-features")]
		public string FontFeatures {
			get {
				GLib.Value val = GetProperty ("font-features");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font-features", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("accumulative-margin")]
		public bool AccumulativeMargin {
			get {
				GLib.Value val = GetProperty ("accumulative-margin");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("accumulative-margin", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background_set")]
		public bool BackgroundSet {
			get {
				GLib.Value val = GetProperty ("background_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background_full_height_set")]
		public bool BackgroundFullHeightSet {
			get {
				GLib.Value val = GetProperty ("background_full_height_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background_full_height_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background_stipple_set")]
		public bool BackgroundStippleSet {
			get {
				GLib.Value val = GetProperty ("background_stipple_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background_stipple_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground_set")]
		public bool ForegroundSet {
			get {
				GLib.Value val = GetProperty ("foreground_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("foreground_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground_stipple_set")]
		public bool ForegroundStippleSet {
			get {
				GLib.Value val = GetProperty ("foreground_stipple_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("foreground_stipple_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("editable_set")]
		public bool EditableSet {
			get {
				GLib.Value val = GetProperty ("editable_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("editable_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("family_set")]
		public bool FamilySet {
			get {
				GLib.Value val = GetProperty ("family_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("family_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("style_set")]
		public bool StyleSet {
			get {
				GLib.Value val = GetProperty ("style_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("style_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("variant_set")]
		public bool VariantSet {
			get {
				GLib.Value val = GetProperty ("variant_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("variant_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("weight_set")]
		public bool WeightSet {
			get {
				GLib.Value val = GetProperty ("weight_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("weight_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("stretch_set")]
		public bool StretchSet {
			get {
				GLib.Value val = GetProperty ("stretch_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("stretch_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size_set")]
		public bool SizeSet {
			get {
				GLib.Value val = GetProperty ("size_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("scale_set")]
		public bool ScaleSet {
			get {
				GLib.Value val = GetProperty ("scale_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("scale_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("justification_set")]
		public bool JustificationSet {
			get {
				GLib.Value val = GetProperty ("justification_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("justification_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("language_set")]
		public bool LanguageSet {
			get {
				GLib.Value val = GetProperty ("language_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("language_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("left_margin_set")]
		public bool LeftMarginSet {
			get {
				GLib.Value val = GetProperty ("left_margin_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("left_margin_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("indent_set")]
		public bool IndentSet {
			get {
				GLib.Value val = GetProperty ("indent_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("indent_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("rise_set")]
		public bool RiseSet {
			get {
				GLib.Value val = GetProperty ("rise_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("rise_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pixels_above_lines_set")]
		public bool PixelsAboveLinesSet {
			get {
				GLib.Value val = GetProperty ("pixels_above_lines_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pixels_above_lines_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pixels_below_lines_set")]
		public bool PixelsBelowLinesSet {
			get {
				GLib.Value val = GetProperty ("pixels_below_lines_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pixels_below_lines_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pixels_inside_wrap_set")]
		public bool PixelsInsideWrapSet {
			get {
				GLib.Value val = GetProperty ("pixels_inside_wrap_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pixels_inside_wrap_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("strikethrough_set")]
		public bool StrikethroughSet {
			get {
				GLib.Value val = GetProperty ("strikethrough_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("strikethrough_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("right_margin_set")]
		public bool RightMarginSet {
			get {
				GLib.Value val = GetProperty ("right_margin_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("right_margin_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("underline_set")]
		public bool UnderlineSet {
			get {
				GLib.Value val = GetProperty ("underline_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("underline_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("wrap_mode_set")]
		public bool WrapModeSet {
			get {
				GLib.Value val = GetProperty ("wrap_mode_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("wrap_mode_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("tabs_set")]
		public bool TabsSet {
			get {
				GLib.Value val = GetProperty ("tabs_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("tabs_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("invisible_set")]
		public bool InvisibleSet {
			get {
				GLib.Value val = GetProperty ("invisible_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("invisible_set", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("event")]
		public event Gtk.TextEventHandler TextEvent {
			add {
				this.AddSignalHandler ("event", value, typeof (Gtk.TextEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("event", value);
			}
		}

		static TextEventNativeDelegate TextEvent_cb_delegate;
		static TextEventNativeDelegate TextEventVMCallback {
			get {
				if (TextEvent_cb_delegate == null)
					TextEvent_cb_delegate = new TextEventNativeDelegate (TextEvent_cb);
				return TextEvent_cb_delegate;
			}
		}

		static void OverrideTextEvent (GLib.GType gtype)
		{
			OverrideTextEvent (gtype, TextEventVMCallback);
		}

		static void OverrideTextEvent (GLib.GType gtype, TextEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool TextEventNativeDelegate (IntPtr inst, IntPtr event_object, IntPtr evnt, IntPtr iter);

		static bool TextEvent_cb (IntPtr inst, IntPtr event_object, IntPtr evnt, IntPtr iter)
		{
			try {
				TextTag __obj = GLib.Object.GetObject (inst, false) as TextTag;
				bool __result;
				__result = __obj.OnTextEvent (GLib.Object.GetObject (event_object), Gdk.Event.GetEvent (evnt), Gtk.TextIter.New (iter));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.TextTag), ConnectionMethod="OverrideTextEvent")]
		protected virtual bool OnTextEvent (GLib.Object event_object, Gdk.Event evnt, Gtk.TextIter iter)
		{
			return InternalTextEvent (event_object, evnt, iter);
		}

		private bool InternalTextEvent (GLib.Object event_object, Gdk.Event evnt, Gtk.TextIter iter)
		{
			TextEventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("event"));
				unmanaged = (TextEventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TextEventNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool __result = unmanaged (this.Handle, event_object == null ? IntPtr.Zero : event_object.Handle, evnt == null ? IntPtr.Zero : evnt.Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("event"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // event
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "event"
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
		static extern void gtk_text_tag_changed(IntPtr raw, bool size_changed);

		public void Changed(bool size_changed) {
			gtk_text_tag_changed(Handle, size_changed);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_text_tag_event(IntPtr raw, IntPtr event_object, IntPtr evnt, IntPtr iter);

		public bool ProcessEvent(GLib.Object event_object, Gdk.Event evnt, Gtk.TextIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_text_tag_event(Handle, event_object == null ? IntPtr.Zero : event_object.Handle, evnt == null ? IntPtr.Zero : evnt.Handle, native_iter);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_text_tag_get_priority(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_text_tag_set_priority(IntPtr raw, int priority);

		public int Priority { 
			get {
				int raw_ret = gtk_text_tag_get_priority(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				gtk_text_tag_set_priority(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_tag_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_text_tag_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
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
