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

internal class neural_net : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal neural_net(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(neural_net obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~neural_net() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fannfixedPINVOKE.delete_neural_net(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public neural_net(NetworkType net_type, uint num_layers, SWIGTYPE_p_unsigned_int layers) : this(fannfixedPINVOKE.new_neural_net__SWIG_0((int)net_type, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers)), true) {
  }

  public neural_net(NetworkType net_type, uint num_layers) : this(fannfixedPINVOKE.new_neural_net__SWIG_2((int)net_type, num_layers), true) {
  }

  public neural_net(float connection_rate, uint num_layers) : this(fannfixedPINVOKE.new_neural_net__SWIG_3(connection_rate, num_layers), true) {
  }

  public neural_net(float connection_rate, uint num_layers, SWIGTYPE_p_unsigned_int layers) : this(fannfixedPINVOKE.new_neural_net__SWIG_4(connection_rate, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers)), true) {
  }

  public neural_net(string configuration_file) : this(fannfixedPINVOKE.new_neural_net__SWIG_5(configuration_file), true) {
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
  }

  public neural_net(neural_net other) : this(fannfixedPINVOKE.new_neural_net__SWIG_6(neural_net.getCPtr(other)), true) {
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
  }

  public neural_net(SWIGTYPE_p_fann other) : this(fannfixedPINVOKE.new_neural_net__SWIG_7(SWIGTYPE_p_fann.getCPtr(other)), true) {
  }

  public neural_net() : this(fannfixedPINVOKE.new_neural_net__SWIG_8(), true) {
  }

  public void copy_from_struct_fann(SWIGTYPE_p_fann other) {
    fannfixedPINVOKE.neural_net_copy_from_struct_fann(swigCPtr, SWIGTYPE_p_fann.getCPtr(other));
  }

  public void destroy() {
    fannfixedPINVOKE.neural_net_destroy(swigCPtr);
  }

  public bool create_standard(uint num_layers) {
    bool ret = fannfixedPINVOKE.neural_net_create_standard(swigCPtr, num_layers);
    return ret;
  }

  public bool create_standard_array(uint num_layers, SWIGTYPE_p_unsigned_int layers) {
    bool ret = fannfixedPINVOKE.neural_net_create_standard_array(swigCPtr, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers));
    return ret;
  }

  public bool create_sparse(float connection_rate, uint num_layers) {
    bool ret = fannfixedPINVOKE.neural_net_create_sparse(swigCPtr, connection_rate, num_layers);
    return ret;
  }

  public bool create_sparse_array(float connection_rate, uint num_layers, SWIGTYPE_p_unsigned_int layers) {
    bool ret = fannfixedPINVOKE.neural_net_create_sparse_array(swigCPtr, connection_rate, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers));
    return ret;
  }

  public bool create_shortcut(uint num_layers) {
    bool ret = fannfixedPINVOKE.neural_net_create_shortcut(swigCPtr, num_layers);
    return ret;
  }

  public bool create_shortcut_array(uint num_layers, SWIGTYPE_p_unsigned_int layers) {
    bool ret = fannfixedPINVOKE.neural_net_create_shortcut_array(swigCPtr, num_layers, SWIGTYPE_p_unsigned_int.getCPtr(layers));
    return ret;
  }

  public SWIGTYPE_p_int run(int[] input) {
    global::System.IntPtr cPtr = fannfixedPINVOKE.neural_net_run(swigCPtr, input);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public void randomize_weights(int min_weight, int max_weight) {
    fannfixedPINVOKE.neural_net_randomize_weights(swigCPtr, min_weight, max_weight);
  }

  public void init_weights(training_data data) {
    fannfixedPINVOKE.neural_net_init_weights(swigCPtr, training_data.getCPtr(data));
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
  }

  public void print_connections() {
    fannfixedPINVOKE.neural_net_print_connections(swigCPtr);
  }

  public bool create_from_file(string configuration_file) {
    bool ret = fannfixedPINVOKE.neural_net_create_from_file(swigCPtr, configuration_file);
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool save(string configuration_file) {
    bool ret = fannfixedPINVOKE.neural_net_save(swigCPtr, configuration_file);
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int save_to_fixed(string configuration_file) {
    int ret = fannfixedPINVOKE.neural_net_save_to_fixed(swigCPtr, configuration_file);
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_int test(int[] input, int[] desired_output) {
    global::System.IntPtr cPtr = fannfixedPINVOKE.neural_net_test(swigCPtr, input, desired_output);
    SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public float test_data(training_data data) {
    float ret = fannfixedPINVOKE.neural_net_test_data(swigCPtr, training_data.getCPtr(data));
    if (fannfixedPINVOKE.SWIGPendingException.Pending) throw fannfixedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float get_MSE() {
    float ret = fannfixedPINVOKE.neural_net_get_MSE(swigCPtr);
    return ret;
  }

  public void reset_MSE() {
    fannfixedPINVOKE.neural_net_reset_MSE(swigCPtr);
  }

  public void print_parameters() {
    fannfixedPINVOKE.neural_net_print_parameters(swigCPtr);
  }

  public TrainingAlgorithm get_training_algorithm() {
    TrainingAlgorithm ret = (TrainingAlgorithm)fannfixedPINVOKE.neural_net_get_training_algorithm(swigCPtr);
    return ret;
  }

  public void set_training_algorithm(TrainingAlgorithm training_algorithm) {
    fannfixedPINVOKE.neural_net_set_training_algorithm(swigCPtr, (int)training_algorithm);
  }

  public float get_learning_rate() {
    float ret = fannfixedPINVOKE.neural_net_get_learning_rate(swigCPtr);
    return ret;
  }

  public void set_learning_rate(float learning_rate) {
    fannfixedPINVOKE.neural_net_set_learning_rate(swigCPtr, learning_rate);
  }

  public ActivationFunction get_activation_function(int layer, int neuron) {
    ActivationFunction ret = (ActivationFunction)fannfixedPINVOKE.neural_net_get_activation_function(swigCPtr, layer, neuron);
    return ret;
  }

  public void set_activation_function(ActivationFunction activation_function, int layer, int neuron) {
    fannfixedPINVOKE.neural_net_set_activation_function(swigCPtr, (int)activation_function, layer, neuron);
  }

  public void set_activation_function_layer(ActivationFunction activation_function, int layer) {
    fannfixedPINVOKE.neural_net_set_activation_function_layer(swigCPtr, (int)activation_function, layer);
  }

  public void set_activation_function_hidden(ActivationFunction activation_function) {
    fannfixedPINVOKE.neural_net_set_activation_function_hidden(swigCPtr, (int)activation_function);
  }

  public void set_activation_function_output(ActivationFunction activation_function) {
    fannfixedPINVOKE.neural_net_set_activation_function_output(swigCPtr, (int)activation_function);
  }

  public int get_activation_steepness(int layer, int neuron) {
    int ret = fannfixedPINVOKE.neural_net_get_activation_steepness(swigCPtr, layer, neuron);
    return ret;
  }

  public void set_activation_steepness(int steepness, int layer, int neuron) {
    fannfixedPINVOKE.neural_net_set_activation_steepness(swigCPtr, steepness, layer, neuron);
  }

  public void set_activation_steepness_layer(int steepness, int layer) {
    fannfixedPINVOKE.neural_net_set_activation_steepness_layer(swigCPtr, steepness, layer);
  }

  public void set_activation_steepness_hidden(int steepness) {
    fannfixedPINVOKE.neural_net_set_activation_steepness_hidden(swigCPtr, steepness);
  }

  public void set_activation_steepness_output(int steepness) {
    fannfixedPINVOKE.neural_net_set_activation_steepness_output(swigCPtr, steepness);
  }

  public ErrorFunction get_train_error_function() {
    ErrorFunction ret = (ErrorFunction)fannfixedPINVOKE.neural_net_get_train_error_function(swigCPtr);
    return ret;
  }

  public void set_train_error_function(ErrorFunction train_error_function) {
    fannfixedPINVOKE.neural_net_set_train_error_function(swigCPtr, (int)train_error_function);
  }

  public float get_quickprop_decay() {
    float ret = fannfixedPINVOKE.neural_net_get_quickprop_decay(swigCPtr);
    return ret;
  }

  public void set_quickprop_decay(float quickprop_decay) {
    fannfixedPINVOKE.neural_net_set_quickprop_decay(swigCPtr, quickprop_decay);
  }

  public float get_quickprop_mu() {
    float ret = fannfixedPINVOKE.neural_net_get_quickprop_mu(swigCPtr);
    return ret;
  }

  public void set_quickprop_mu(float quickprop_mu) {
    fannfixedPINVOKE.neural_net_set_quickprop_mu(swigCPtr, quickprop_mu);
  }

  public float get_rprop_increase_factor() {
    float ret = fannfixedPINVOKE.neural_net_get_rprop_increase_factor(swigCPtr);
    return ret;
  }

  public void set_rprop_increase_factor(float rprop_increase_factor) {
    fannfixedPINVOKE.neural_net_set_rprop_increase_factor(swigCPtr, rprop_increase_factor);
  }

  public float get_rprop_decrease_factor() {
    float ret = fannfixedPINVOKE.neural_net_get_rprop_decrease_factor(swigCPtr);
    return ret;
  }

  public void set_rprop_decrease_factor(float rprop_decrease_factor) {
    fannfixedPINVOKE.neural_net_set_rprop_decrease_factor(swigCPtr, rprop_decrease_factor);
  }

  public float get_rprop_delta_zero() {
    float ret = fannfixedPINVOKE.neural_net_get_rprop_delta_zero(swigCPtr);
    return ret;
  }

  public void set_rprop_delta_zero(float rprop_delta_zero) {
    fannfixedPINVOKE.neural_net_set_rprop_delta_zero(swigCPtr, rprop_delta_zero);
  }

  public float get_rprop_delta_min() {
    float ret = fannfixedPINVOKE.neural_net_get_rprop_delta_min(swigCPtr);
    return ret;
  }

  public void set_rprop_delta_min(float rprop_delta_min) {
    fannfixedPINVOKE.neural_net_set_rprop_delta_min(swigCPtr, rprop_delta_min);
  }

  public float get_rprop_delta_max() {
    float ret = fannfixedPINVOKE.neural_net_get_rprop_delta_max(swigCPtr);
    return ret;
  }

  public void set_rprop_delta_max(float rprop_delta_max) {
    fannfixedPINVOKE.neural_net_set_rprop_delta_max(swigCPtr, rprop_delta_max);
  }

  public float get_sarprop_weight_decay_shift() {
    float ret = fannfixedPINVOKE.neural_net_get_sarprop_weight_decay_shift(swigCPtr);
    return ret;
  }

  public void set_sarprop_weight_decay_shift(float sarprop_weight_decay_shift) {
    fannfixedPINVOKE.neural_net_set_sarprop_weight_decay_shift(swigCPtr, sarprop_weight_decay_shift);
  }

  public float get_sarprop_step_error_threshold_factor() {
    float ret = fannfixedPINVOKE.neural_net_get_sarprop_step_error_threshold_factor(swigCPtr);
    return ret;
  }

  public void set_sarprop_step_error_threshold_factor(float sarprop_step_error_threshold_factor) {
    fannfixedPINVOKE.neural_net_set_sarprop_step_error_threshold_factor(swigCPtr, sarprop_step_error_threshold_factor);
  }

  public float get_sarprop_step_error_shift() {
    float ret = fannfixedPINVOKE.neural_net_get_sarprop_step_error_shift(swigCPtr);
    return ret;
  }

  public void set_sarprop_step_error_shift(float sarprop_step_error_shift) {
    fannfixedPINVOKE.neural_net_set_sarprop_step_error_shift(swigCPtr, sarprop_step_error_shift);
  }

  public float get_sarprop_temperature() {
    float ret = fannfixedPINVOKE.neural_net_get_sarprop_temperature(swigCPtr);
    return ret;
  }

  public void set_sarprop_temperature(float sarprop_temperature) {
    fannfixedPINVOKE.neural_net_set_sarprop_temperature(swigCPtr, sarprop_temperature);
  }

  public uint get_num_input() {
    uint ret = fannfixedPINVOKE.neural_net_get_num_input(swigCPtr);
    return ret;
  }

  public uint get_num_output() {
    uint ret = fannfixedPINVOKE.neural_net_get_num_output(swigCPtr);
    return ret;
  }

  public uint get_total_neurons() {
    uint ret = fannfixedPINVOKE.neural_net_get_total_neurons(swigCPtr);
    return ret;
  }

  public uint get_total_connections() {
    uint ret = fannfixedPINVOKE.neural_net_get_total_connections(swigCPtr);
    return ret;
  }

  public uint get_decimal_point() {
    uint ret = fannfixedPINVOKE.neural_net_get_decimal_point(swigCPtr);
    return ret;
  }

  public uint get_multiplier() {
    uint ret = fannfixedPINVOKE.neural_net_get_multiplier(swigCPtr);
    return ret;
  }

  public NetworkType get_network_type() {
    NetworkType ret = (NetworkType)fannfixedPINVOKE.neural_net_get_network_type(swigCPtr);
    return ret;
  }

  public float get_connection_rate() {
    float ret = fannfixedPINVOKE.neural_net_get_connection_rate(swigCPtr);
    return ret;
  }

  public uint get_num_layers() {
    uint ret = fannfixedPINVOKE.neural_net_get_num_layers(swigCPtr);
    return ret;
  }

  public void get_layer_array(SWIGTYPE_p_unsigned_int layers) {
    fannfixedPINVOKE.neural_net_get_layer_array(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(layers));
  }

  public void get_bias_array(SWIGTYPE_p_unsigned_int bias) {
    fannfixedPINVOKE.neural_net_get_bias_array(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(bias));
  }

  public void get_connection_array(Connection connections) {
    fannfixedPINVOKE.neural_net_get_connection_array(swigCPtr, Connection.getCPtr(connections));
  }

  public void set_weight_array(Connection connections, uint num_connections) {
    fannfixedPINVOKE.neural_net_set_weight_array(swigCPtr, Connection.getCPtr(connections), num_connections);
  }

  public void set_weight(uint from_neuron, uint to_neuron, int weight) {
    fannfixedPINVOKE.neural_net_set_weight(swigCPtr, from_neuron, to_neuron, weight);
  }

  public float get_learning_momentum() {
    float ret = fannfixedPINVOKE.neural_net_get_learning_momentum(swigCPtr);
    return ret;
  }

  public void set_learning_momentum(float learning_momentum) {
    fannfixedPINVOKE.neural_net_set_learning_momentum(swigCPtr, learning_momentum);
  }

  public StopFunction get_train_stop_function() {
    StopFunction ret = (StopFunction)fannfixedPINVOKE.neural_net_get_train_stop_function(swigCPtr);
    return ret;
  }

  public void set_train_stop_function(StopFunction train_stop_function) {
    fannfixedPINVOKE.neural_net_set_train_stop_function(swigCPtr, (int)train_stop_function);
  }

  public int get_bit_fail_limit() {
    int ret = fannfixedPINVOKE.neural_net_get_bit_fail_limit(swigCPtr);
    return ret;
  }

  public void set_bit_fail_limit(int bit_fail_limit) {
    fannfixedPINVOKE.neural_net_set_bit_fail_limit(swigCPtr, bit_fail_limit);
  }

  public uint get_bit_fail() {
    uint ret = fannfixedPINVOKE.neural_net_get_bit_fail(swigCPtr);
    return ret;
  }

  public void set_error_log(SWIGTYPE_p_FILE log_file) {
    fannfixedPINVOKE.neural_net_set_error_log(swigCPtr, SWIGTYPE_p_FILE.getCPtr(log_file));
  }

  public uint get_errno() {
    uint ret = fannfixedPINVOKE.neural_net_get_errno(swigCPtr);
    return ret;
  }

  public void reset_errno() {
    fannfixedPINVOKE.neural_net_reset_errno(swigCPtr);
  }

  public void reset_errstr() {
    fannfixedPINVOKE.neural_net_reset_errstr(swigCPtr);
  }

  public string get_errstr() {
    string ret = fannfixedPINVOKE.neural_net_get_errstr(swigCPtr);
    return ret;
  }

  public void print_error() {
    fannfixedPINVOKE.neural_net_print_error(swigCPtr);
  }

  public void disable_seed_rand() {
    fannfixedPINVOKE.neural_net_disable_seed_rand(swigCPtr);
  }

  public void enable_seed_rand() {
    fannfixedPINVOKE.neural_net_enable_seed_rand(swigCPtr);
  }

  public SWIGTYPE_p_fann to_fann() {
    global::System.IntPtr cPtr = fannfixedPINVOKE.neural_net_to_fann(swigCPtr);
    SWIGTYPE_p_fann ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_fann(cPtr, false);
    return ret;
  }

}

}
