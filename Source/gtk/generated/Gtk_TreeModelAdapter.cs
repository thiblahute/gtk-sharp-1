// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TreeModelAdapter : GLib.GInterfaceAdapter, Gtk.ITreeModel {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkTreeModelIface {
			IntPtr RowChanged;
			IntPtr RowInserted;
			IntPtr RowHasChildToggled;
			IntPtr RowDeleted;
			IntPtr RowsReordered;
			public GetFlagsNativeDelegate GetFlags;
			public GetNColumnsNativeDelegate GetNColumns;
			public GetColumnTypeNativeDelegate GetColumnType;
			public GetIterNativeDelegate GetIter;
			public GetPathNativeDelegate GetPath;
			public GetValueNativeDelegate GetValue;
			public IterNextNativeDelegate IterNext;
			public IterPreviousNativeDelegate IterPrevious;
			public IterChildrenNativeDelegate IterChildren;
			public IterHasChildNativeDelegate IterHasChild;
			public IterNChildrenNativeDelegate IterNChildren;
			public IterNthChildNativeDelegate IterNthChild;
			public IterParentNativeDelegate IterParent;
			public RefNodeNativeDelegate RefNode;
			public UnrefNodeNativeDelegate UnrefNode;
		}

		static GtkTreeModelIface iface;

		static TreeModelAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (TreeModelAdapter));
			iface.GetFlags = new GetFlagsNativeDelegate (GetFlags_cb);
			iface.GetNColumns = new GetNColumnsNativeDelegate (GetNColumns_cb);
			iface.GetColumnType = new GetColumnTypeNativeDelegate (GetColumnType_cb);
			iface.GetIter = new GetIterNativeDelegate (GetIter_cb);
			iface.GetPath = new GetPathNativeDelegate (GetPath_cb);
			iface.GetValue = new GetValueNativeDelegate (GetValue_cb);
			iface.IterNext = new IterNextNativeDelegate (IterNext_cb);
			iface.IterPrevious = new IterPreviousNativeDelegate (IterPrevious_cb);
			iface.IterChildren = new IterChildrenNativeDelegate (IterChildren_cb);
			iface.IterHasChild = new IterHasChildNativeDelegate (IterHasChild_cb);
			iface.IterNChildren = new IterNChildrenNativeDelegate (IterNChildren_cb);
			iface.IterNthChild = new IterNthChildNativeDelegate (IterNthChild_cb);
			iface.IterParent = new IterParentNativeDelegate (IterParent_cb);
			iface.RefNode = new RefNodeNativeDelegate (RefNode_cb);
			iface.UnrefNode = new UnrefNodeNativeDelegate (UnrefNode_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetFlagsNativeDelegate (IntPtr inst);

		static int GetFlags_cb (IntPtr inst)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				Gtk.TreeModelFlags __result;
				__result = __obj.Flags;
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNColumnsNativeDelegate (IntPtr inst);

		static int GetNColumns_cb (IntPtr inst)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				int __result;
				__result = __obj.NColumns;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetColumnTypeNativeDelegate (IntPtr inst, int index_);

		static IntPtr GetColumnType_cb (IntPtr inst, int index_)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				GLib.GType __result;
				__result = __obj.GetColumnType (index_);
				return __result.Val;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetIterNativeDelegate (IntPtr inst, IntPtr iter, IntPtr path);

		static bool GetIter_cb (IntPtr inst, IntPtr iter, IntPtr path)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				bool __result;
				Gtk.TreeIter myiter;
				__result = __obj.GetIter (out myiter, path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false));
				if (iter != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myiter, iter, false);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetPathNativeDelegate (IntPtr inst, IntPtr iter);

		static IntPtr GetPath_cb (IntPtr inst, IntPtr iter)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				Gtk.TreePath __result;
				__result = __obj.GetPath (Gtk.TreeIter.New (iter));
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetValueNativeDelegate (IntPtr inst, IntPtr iter, int column, IntPtr value);

		static void GetValue_cb (IntPtr inst, IntPtr iter, int column, IntPtr value)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				GLib.Value myvalue = (GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value));
				__obj.GetValue (Gtk.TreeIter.New (iter), column, ref myvalue);
				if (value != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myvalue, value, false);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IterNextNativeDelegate (IntPtr inst, IntPtr iter);

		static bool IterNext_cb (IntPtr inst, IntPtr iter)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				bool __result;
				Gtk.TreeIter myiter = Gtk.TreeIter.New (iter);
				__result = __obj.IterNext (ref myiter);
				if (iter != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myiter, iter, false);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IterPreviousNativeDelegate (IntPtr inst, IntPtr iter);

		static bool IterPrevious_cb (IntPtr inst, IntPtr iter)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				bool __result;
				Gtk.TreeIter myiter = Gtk.TreeIter.New (iter);
				__result = __obj.IterPrevious (ref myiter);
				if (iter != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myiter, iter, false);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IterChildrenNativeDelegate (IntPtr inst, IntPtr iter, IntPtr parent);

		static bool IterChildren_cb (IntPtr inst, IntPtr iter, IntPtr parent)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				bool __result;
				Gtk.TreeIter myiter;
				__result = __obj.IterChildren (out myiter, Gtk.TreeIter.New (parent));
				if (iter != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myiter, iter, false);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IterHasChildNativeDelegate (IntPtr inst, IntPtr iter);

		static bool IterHasChild_cb (IntPtr inst, IntPtr iter)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				bool __result;
				__result = __obj.IterHasChild (Gtk.TreeIter.New (iter));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int IterNChildrenNativeDelegate (IntPtr inst, IntPtr iter);

		static int IterNChildren_cb (IntPtr inst, IntPtr iter)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				int __result;
				__result = __obj.IterNChildren (Gtk.TreeIter.New (iter));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IterNthChildNativeDelegate (IntPtr inst, IntPtr iter, IntPtr parent, int n);

		static bool IterNthChild_cb (IntPtr inst, IntPtr iter, IntPtr parent, int n)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				bool __result;
				Gtk.TreeIter myiter;
				__result = __obj.IterNthChild (out myiter, Gtk.TreeIter.New (parent), n);
				if (iter != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myiter, iter, false);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IterParentNativeDelegate (IntPtr inst, IntPtr iter, IntPtr child);

		static bool IterParent_cb (IntPtr inst, IntPtr iter, IntPtr child)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				bool __result;
				Gtk.TreeIter myiter;
				__result = __obj.IterParent (out myiter, Gtk.TreeIter.New (child));
				if (iter != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myiter, iter, false);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RefNodeNativeDelegate (IntPtr inst, IntPtr iter);

		static void RefNode_cb (IntPtr inst, IntPtr iter)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				__obj.RefNode (Gtk.TreeIter.New (iter));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UnrefNodeNativeDelegate (IntPtr inst, IntPtr iter);

		static void UnrefNode_cb (IntPtr inst, IntPtr iter)
		{
			try {
				ITreeModelImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeModelImplementor;
				__obj.UnrefNode (Gtk.TreeIter.New (iter));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkTreeModelIface native_iface = (GtkTreeModelIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkTreeModelIface));
			native_iface.GetFlags = iface.GetFlags;
			native_iface.GetNColumns = iface.GetNColumns;
			native_iface.GetColumnType = iface.GetColumnType;
			native_iface.GetIter = iface.GetIter;
			native_iface.GetPath = iface.GetPath;
			native_iface.GetValue = iface.GetValue;
			native_iface.IterNext = iface.IterNext;
			native_iface.IterPrevious = iface.IterPrevious;
			native_iface.IterChildren = iface.IterChildren;
			native_iface.IterHasChild = iface.IterHasChild;
			native_iface.IterNChildren = iface.IterNChildren;
			native_iface.IterNthChild = iface.IterNthChild;
			native_iface.IterParent = iface.IterParent;
			native_iface.RefNode = iface.RefNode;
			native_iface.UnrefNode = iface.UnrefNode;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public TreeModelAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public TreeModelAdapter (ITreeModelImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public TreeModelAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_model_get_type();

		private static GLib.GType _gtype = new GLib.GType (gtk_tree_model_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static ITreeModel GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ITreeModel GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ITreeModelImplementor)
				return new TreeModelAdapter (obj as ITreeModelImplementor);
			else if (obj as ITreeModel == null)
				return new TreeModelAdapter (obj.Handle);
			else
				return obj as ITreeModel;
		}

		public ITreeModelImplementor Implementor {
			get {
				return implementor as ITreeModelImplementor;
			}
		}

		[GLib.Signal("row-changed")]
		public event Gtk.RowChangedHandler RowChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("row-changed", value, typeof (Gtk.RowChangedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("row-changed", value);
			}
		}

		[GLib.Signal("row-has-child-toggled")]
		public event Gtk.RowHasChildToggledHandler RowHasChildToggled {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("row-has-child-toggled", value, typeof (Gtk.RowHasChildToggledArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("row-has-child-toggled", value);
			}
		}

		[GLib.Signal("row-inserted")]
		public event Gtk.RowInsertedHandler RowInserted {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("row-inserted", value, typeof (Gtk.RowInsertedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("row-inserted", value);
			}
		}

		[GLib.Signal("row-deleted")]
		public event Gtk.RowDeletedHandler RowDeleted {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("row-deleted", value, typeof (Gtk.RowDeletedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("row-deleted", value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_foreach(IntPtr raw, GtkSharp.TreeModelForeachFuncNative func, IntPtr user_data);

		public void Foreach(Gtk.TreeModelForeachFunc func) {
			GtkSharp.TreeModelForeachFuncWrapper func_wrapper = new GtkSharp.TreeModelForeachFuncWrapper (func);
			gtk_tree_model_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_model_get_column_type(IntPtr raw, int index_);

		public GLib.GType GetColumnType(int index_) {
			IntPtr raw_ret = gtk_tree_model_get_column_type(Handle, index_);
			GLib.GType ret = new GLib.GType(raw_ret);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_model_get_flags(IntPtr raw);

		public Gtk.TreeModelFlags Flags { 
			get {
				int raw_ret = gtk_tree_model_get_flags(Handle);
				Gtk.TreeModelFlags ret = (Gtk.TreeModelFlags) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_get_iter(IntPtr raw, IntPtr iter, IntPtr path);

		public bool GetIter(out Gtk.TreeIter iter, Gtk.TreePath path) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			bool raw_ret = gtk_tree_model_get_iter(Handle, native_iter, path == null ? IntPtr.Zero : path.Handle);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_get_iter_first(IntPtr raw, IntPtr iter);

		public bool GetIterFirst(out Gtk.TreeIter iter) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			bool raw_ret = gtk_tree_model_get_iter_first(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_get_iter_from_string(IntPtr raw, IntPtr iter, IntPtr path_string);

		public bool GetIterFromString(out Gtk.TreeIter iter, string path_string) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_path_string = GLib.Marshaller.StringToPtrGStrdup (path_string);
			bool raw_ret = gtk_tree_model_get_iter_from_string(Handle, native_iter, native_path_string);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			GLib.Marshaller.Free (native_path_string);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_model_get_n_columns(IntPtr raw);

		public int NColumns { 
			get {
				int raw_ret = gtk_tree_model_get_n_columns(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_model_get_path(IntPtr raw, IntPtr iter);

		public Gtk.TreePath GetPath(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr raw_ret = gtk_tree_model_get_path(Handle, native_iter);
			Gtk.TreePath ret = raw_ret == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TreePath), true);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_model_get_string_from_iter(IntPtr raw, IntPtr iter);

		public string GetStringFromIter(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr raw_ret = gtk_tree_model_get_string_from_iter(Handle, native_iter);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_get_valist(IntPtr raw, IntPtr iter, IntPtr var_args);

		public void GetValist(Gtk.TreeIter iter, IntPtr var_args) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_get_valist(Handle, native_iter, var_args);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_get_value(IntPtr raw, IntPtr iter, int column, IntPtr value);

		public void GetValue(Gtk.TreeIter iter, int column, ref GLib.Value value) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gtk_tree_model_get_value(Handle, native_iter, column, native_value);
			Marshal.FreeHGlobal (native_iter);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_children(IntPtr raw, IntPtr iter, IntPtr parent);

		public bool IterChildren(out Gtk.TreeIter iter, Gtk.TreeIter parent) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_parent = GLib.Marshaller.StructureToPtrAlloc (parent);
			bool raw_ret = gtk_tree_model_iter_children(Handle, native_iter, native_parent);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_parent);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_has_child(IntPtr raw, IntPtr iter);

		public bool IterHasChild(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_tree_model_iter_has_child(Handle, native_iter);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_model_iter_n_children(IntPtr raw, IntPtr iter);

		public int IterNChildren(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			int raw_ret = gtk_tree_model_iter_n_children(Handle, native_iter);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_next(IntPtr raw, IntPtr iter);

		public bool IterNext(ref Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_tree_model_iter_next(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_nth_child(IntPtr raw, IntPtr iter, IntPtr parent, int n);

		public bool IterNthChild(out Gtk.TreeIter iter, Gtk.TreeIter parent, int n) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_parent = GLib.Marshaller.StructureToPtrAlloc (parent);
			bool raw_ret = gtk_tree_model_iter_nth_child(Handle, native_iter, native_parent, n);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_parent);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_parent(IntPtr raw, IntPtr iter, IntPtr child);

		public bool IterParent(out Gtk.TreeIter iter, Gtk.TreeIter child) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_child = GLib.Marshaller.StructureToPtrAlloc (child);
			bool raw_ret = gtk_tree_model_iter_parent(Handle, native_iter, native_child);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_child);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_previous(IntPtr raw, IntPtr iter);

		public bool IterPrevious(ref Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_tree_model_iter_previous(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_ref_node(IntPtr raw, IntPtr iter);

		public void RefNode(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_ref_node(Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_changed(IntPtr raw, IntPtr path, IntPtr iter);

		public void EmitRowChanged(Gtk.TreePath path, Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_row_changed(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_deleted(IntPtr raw, IntPtr path);

		public void EmitRowDeleted(Gtk.TreePath path) {
			gtk_tree_model_row_deleted(Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_has_child_toggled(IntPtr raw, IntPtr path, IntPtr iter);

		public void EmitRowHasChildToggled(Gtk.TreePath path, Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_row_has_child_toggled(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_inserted(IntPtr raw, IntPtr path, IntPtr iter);

		public void EmitRowInserted(Gtk.TreePath path, Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_row_inserted(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_rows_reordered(IntPtr raw, IntPtr path, IntPtr iter, int[] new_order);

		public void EmitRowsReordered(Gtk.TreePath path, Gtk.TreeIter iter, int[] new_order) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_rows_reordered(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter, new_order);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_rows_reordered_with_length(IntPtr raw, IntPtr path, IntPtr iter, out int new_order, int length);

		public int RowsReorderedWithLength(Gtk.TreePath path, Gtk.TreeIter iter, int length) {
			int new_order;
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_rows_reordered_with_length(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter, out new_order, length);
			Marshal.FreeHGlobal (native_iter);
			return new_order;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_unref_node(IntPtr raw, IntPtr iter);

		public void UnrefNode(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_unref_node(Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

#endregion
	}
}
