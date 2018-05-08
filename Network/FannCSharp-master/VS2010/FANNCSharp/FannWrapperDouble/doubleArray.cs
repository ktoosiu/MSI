//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using FANNCSharp;
namespace FannWrapperDouble {

internal class doubleArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal doubleArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(doubleArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~doubleArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fanndoublePINVOKE.delete_doubleArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public doubleArray(int nelements) : this(fanndoublePINVOKE.new_doubleArray(nelements), true) {
  }

  public double getitem(int index) {
    double ret = fanndoublePINVOKE.doubleArray_getitem(swigCPtr, index);
    return ret;
  }

  public void setitem(int index, double value) {
    fanndoublePINVOKE.doubleArray_setitem(swigCPtr, index, value);
  }

  public SWIGTYPE_p_double cast() {
    global::System.IntPtr cPtr = fanndoublePINVOKE.doubleArray_cast(swigCPtr);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public static doubleArray frompointer(SWIGTYPE_p_double t) {
    global::System.IntPtr cPtr = fanndoublePINVOKE.doubleArray_frompointer(SWIGTYPE_p_double.getCPtr(t));
    doubleArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new doubleArray(cPtr, false);
    return ret;
  }

}

}
