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

internal class training_data : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal training_data(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(training_data obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~training_data() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fannfixedPINVOKE.delete_training_data(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public training_data() : this(fannfixedPINVOKE.new_training_data__SWIG_0(), true) {
  }

  public training_data(training_data data) : this(fannfixedPINVOKE.new_training_data__SWIG_1(training_data.getCPtr(data)), true) {
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroy_train() {
    fannfixedPINVOKE.training_data_destroy_train(swigCPtr);
  }

  public bool read_train_from_file(string filename) {
    bool ret = fannfixedPINVOKE.training_data_read_train_from_file(swigCPtr, filename);
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_train(string filename) {
    bool ret = fannfixedPINVOKE.training_data_save_train(swigCPtr, filename);
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save_train_to_fixed(string filename, uint decimal_point) {
    bool ret = fannfixedPINVOKE.training_data_save_train_to_fixed(swigCPtr, filename, decimal_point);
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void shuffle_train_data() {
    fannfixedPINVOKE.training_data_shuffle_train_data(swigCPtr);
  }

  public void merge_train_data(training_data data) {
    fannfixedPINVOKE.training_data_merge_train_data(swigCPtr, training_data.getCPtr(data));
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint length_train_data() {
    uint ret = fannfixedPINVOKE.training_data_length_train_data(swigCPtr);
    return ret;
  }

  public uint num_input_train_data() {
    uint ret = fannfixedPINVOKE.training_data_num_input_train_data(swigCPtr);
    return ret;
  }

  public uint num_output_train_data() {
    uint ret = fannfixedPINVOKE.training_data_num_output_train_data(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_p_int get_input() {
    global::System.IntPtr cPtr = fannfixedPINVOKE.training_data_get_input(swigCPtr);
    SWIGTYPE_p_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_int(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_p_int get_output() {
    global::System.IntPtr cPtr = fannfixedPINVOKE.training_data_get_output(swigCPtr);
    SWIGTYPE_p_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_int(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_int get_train_input(uint position) {
    global::System.IntPtr cPtr = fannfixedPINVOKE.training_data_get_train_input(swigCPtr, position);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_int get_train_output(uint position) {
    global::System.IntPtr cPtr = fannfixedPINVOKE.training_data_get_train_output(swigCPtr, position);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public void set_train_data(uint num_data, uint num_input, SWIGTYPE_p_p_int input, uint num_output, SWIGTYPE_p_p_int output) {
    fannfixedPINVOKE.training_data_set_train_data__SWIG_0(swigCPtr, num_data, num_input, SWIGTYPE_p_p_int.getCPtr(input), num_output, SWIGTYPE_p_p_int.getCPtr(output));
  }

  public void set_train_data(uint num_data, uint num_input, int[] input, uint num_output, int[] output) {
    fannfixedPINVOKE.training_data_set_train_data__SWIG_1(swigCPtr, num_data, num_input, input, num_output, output);
  }

  public void create_train_from_callback(uint num_data, uint num_input, uint num_output, global::System.IntPtr user_function) {
    fannfixedPINVOKE.training_data_create_train_from_callback(swigCPtr, num_data, num_input, num_output, user_function);
  }

  public void scale_input_train_data(int new_min, int new_max) {
    fannfixedPINVOKE.training_data_scale_input_train_data(swigCPtr, new_min, new_max);
  }

  public void scale_output_train_data(int new_min, int new_max) {
    fannfixedPINVOKE.training_data_scale_output_train_data(swigCPtr, new_min, new_max);
  }

  public void scale_train_data(int new_min, int new_max) {
    fannfixedPINVOKE.training_data_scale_train_data(swigCPtr, new_min, new_max);
  }

  public void subset_train_data(uint pos, uint length) {
    fannfixedPINVOKE.training_data_subset_train_data(swigCPtr, pos, length);
  }

  public SWIGTYPE_p_fann_train_data to_fann_train_data() {
    global::System.IntPtr cPtr = fannfixedPINVOKE.training_data_to_fann_train_data(swigCPtr);
    SWIGTYPE_p_fann_train_data ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_fann_train_data(cPtr, false);
    return ret;
  }

}

}
