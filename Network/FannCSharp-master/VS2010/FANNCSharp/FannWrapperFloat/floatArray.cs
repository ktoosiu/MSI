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
namespace FannWrapperFloat {

internal class floatArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal floatArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(floatArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~floatArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fannfloatPINVOKE.delete_floatArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public floatArray(int nelements) : this(fannfloatPINVOKE.new_floatArray(nelements), true) {
  }

  public float getitem(int index) {
    float ret = fannfloatPINVOKE.floatArray_getitem(swigCPtr, index);
    return ret;
  }

  public void setitem(int index, float value) {
    fannfloatPINVOKE.floatArray_setitem(swigCPtr, index, value);
  }

  public SWIGTYPE_p_float cast() {
    global::System.IntPtr cPtr = fannfloatPINVOKE.floatArray_cast(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    return ret;
  }

  public static floatArray frompointer(SWIGTYPE_p_float t) {
    global::System.IntPtr cPtr = fannfloatPINVOKE.floatArray_frompointer(SWIGTYPE_p_float.getCPtr(t));
    floatArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new floatArray(cPtr, false);
    return ret;
  }

}

}
