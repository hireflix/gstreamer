// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServerSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool RTSPSessionPoolFuncNative(IntPtr pool, IntPtr user_data);

	internal class RTSPSessionPoolFuncInvoker {

		RTSPSessionPoolFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~RTSPSessionPoolFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal RTSPSessionPoolFuncInvoker (RTSPSessionPoolFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal RTSPSessionPoolFuncInvoker (RTSPSessionPoolFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal RTSPSessionPoolFuncInvoker (RTSPSessionPoolFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.RtspServer.RTSPSessionPoolFunc Handler {
			get {
				return new Gst.RtspServer.RTSPSessionPoolFunc(InvokeNative);
			}
		}

		bool InvokeNative (Gst.RtspServer.RTSPSessionPool pool)
		{
			bool __result = native_cb (pool == null ? IntPtr.Zero : pool.Handle, __data);
			return __result;
		}
	}

	internal class RTSPSessionPoolFuncWrapper {

		public bool NativeCallback (IntPtr pool, IntPtr user_data)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(pool) as Gst.RtspServer.RTSPSessionPool);
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

		internal RTSPSessionPoolFuncNative NativeDelegate;
		Gst.RtspServer.RTSPSessionPoolFunc managed;

		public RTSPSessionPoolFuncWrapper (Gst.RtspServer.RTSPSessionPoolFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new RTSPSessionPoolFuncNative (NativeCallback);
		}

		public static Gst.RtspServer.RTSPSessionPoolFunc GetManagedDelegate (RTSPSessionPoolFuncNative native)
		{
			if (native == null)
				return null;
			RTSPSessionPoolFuncWrapper wrapper = (RTSPSessionPoolFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}