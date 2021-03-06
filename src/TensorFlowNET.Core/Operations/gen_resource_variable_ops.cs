﻿/*****************************************************************************
   Copyright 2018 The TensorFlow.NET Authors. All Rights Reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
******************************************************************************/

using Tensorflow.Eager;
using static Tensorflow.Binding;

namespace Tensorflow
{
    public static class gen_resource_variable_ops
    {
        public static OpDefLibrary _op_def_lib = new OpDefLibrary();

        public static Operation assign_variable_op(Tensor resource, Tensor value, string name = null)
        {
            if (tf.context.executing_eagerly())
            {
                var _result = wrap_tfe_src.TFE_FastPathExecute(tf.context, tf.context.device_name,
                    "AssignVariableOp", name, null,
                    resource, value);
                return _result;
            }

            var _op = _op_def_lib._apply_op_helper("AssignVariableOp", name, new { resource, value });

            return _op;
        }

        public static Tensor var_is_initialized_op(Tensor resource, string name = null)
        {
            if (tf.context.executing_eagerly())
            {
                var _result = wrap_tfe_src.TFE_FastPathExecute(tf.context, tf.context.device_name,
                    "VarIsInitializedOp", name, null,
                    resource);
                return _result;
            }

            var _op = _op_def_lib._apply_op_helper("VarIsInitializedOp", name, new { resource });

            return _op.output;
        }

        /// <summary>
        /// Creates a handle to a Variable resource.
        /// </summary>
        /// <param name="dtype"></param>
        /// <param name="shape"></param>
        /// <param name="container"></param>
        /// <param name="shared_name"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Tensor var_handle_op(TF_DataType dtype, TensorShape shape, 
            string container ="", string shared_name = "", string name = null)
        {
            if (tf.context.executing_eagerly())
            {
                var _result = wrap_tfe_src.TFE_FastPathExecute(tf.context, tf.context.device_name,
                    "VarHandleOp", name, null,
                    "container", container, "shared_name", shared_name, "dtype", dtype, "shape", shape.dims);
                return _result;
            }

            var _op = _op_def_lib._apply_op_helper("VarHandleOp", name, new {
                dtype,
                shape,
                container,
                shared_name
            });

            return _op.output;
        }

        /// <summary>
        /// Reads the value of a variable.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="dtype"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Tensor read_variable_op(Tensor resource, TF_DataType dtype, string name = null)
        {
            if (tf.context.executing_eagerly())
            {
                var _result = wrap_tfe_src.TFE_FastPathExecute(tf.context, tf.context.device_name,
                    "ReadVariableOp", name, null,
                    resource, "dtype", dtype);
                return _result;
            }

            var _op = _op_def_lib._apply_op_helper("ReadVariableOp", name, new
            {
                resource,
                dtype
            });

            return _op.output;
        }

        public static Tensor resource_gather(Tensor resource, Tensor indices, TF_DataType dtype, 
            int batch_dims = 0, bool validate_indices = true, string name = null)
        {
            var _op = _op_def_lib._apply_op_helper("ResourceGather", name, new
            {
                resource,
                indices,
                dtype,
                batch_dims,
                validate_indices
            });

            return _op.output;
        }
    }
}
