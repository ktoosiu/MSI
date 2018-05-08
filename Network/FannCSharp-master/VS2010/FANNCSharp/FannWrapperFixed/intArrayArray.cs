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
namespace FannWrapperFixed {

internal class intArrayArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal intArrayArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(intArrayArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~intArrayArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fannfixedPINVOKE.delete_intArrayArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public intArrayArray(int nelements) : this(fannfixedPINVOKE.new_intArrayArray(nelements), true) {
  }

  public SWIGTYPE_p_int getitem(int index) {
    global::System.IntPtr cPtr = fannfixedPINVOKE.intArrayArray_getitem(swigCPtr, index);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public void setitem(int index, SWIGTYPE_p_int value) {
    fannfixedPINVOKE.intArrayArray_setitem(swigCPtr, index, SWIGTYPE_p_int.getCPtr(value));
  }

  public SWIGTYPE_p_p_int cast() {
    global::System.IntPtr cPtr = fannfixedPINVOKE.intArrayArray_cast(swigCPtr);
    SWIGTYPE_p_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_int(cPtr, false);
    return ret;
  }

  public static intArrayArray frompointer(SWIGTYPE_p_p_int t) {
    global::System.IntPtr cPtr = fannfixedPINVOKE.intArrayArray_frompointer(SWIGTYPE_p_p_int.getCPtr(t));
    intArrayArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new intArrayArray(cPtr, false);
    return ret;
  }

}

}
