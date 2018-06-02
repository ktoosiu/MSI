//------------------------------------------------------------------------------
/*
 * Title: FANN C# StopFunction enumerator
 */

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace FANNCSharp
{
    /* Enum: StopFunction
	    Stop criteria used during training.

	    STOPFUNC_MSE - Stop criteria is Mean Square Error (MSE) value.
	    STOPFUNC_BIT - Stop criteria is number of bits that fail. The number of bits; means the
		    number of output neurons which differ more than the bit fail limit
		    (see <FANNCSharp.Float::NeuralNet::BitFailLimit>).
		    The bits are counted in all of the training data, so this number can be higher than
		    the number of training data.

	    See also:
		    <FANNCSharp.Float::NeuralNet::TrainStopFunction>
    */
    public enum StopFunction
    {
        STOPFUNC_MSE = 0,
        STOPFUNC_BIT
    }

}
