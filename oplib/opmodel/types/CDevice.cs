﻿// CDevice.cs --- Part of the project OPLib 1.0, a high performance pricing library
// based on operator methods, higher level BLAS and multicore architectures 

// Author:     2009 Claudio Albanese
// Maintainer: Claudio Albanese <claudio@albanese.co.uk>
// Created:    April-July 2009
// Version:    1.0.0
// Credits:    The CUDA code for SGEMM4, SGEMV4 and SSQMM were inspired by 
//             Vasily Volkov's implementation of SGEMM
//			   We use several variations of the multi-threaded Mersenne Twister algorithm of 
//			   period 2203 due to Makoto Matsumoto.
//             The Monte Carlo routine in SMC includes code by Victor Podlozhnyuk 
//             included in the CUDA SDK.
//             CPU-side BLAS and random number generators link to primitives in the
//			   Intel Math Kernel Libraries. 


// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; see the file COPYING.  If not, write to
// the Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.



using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OPModel.Types
{
    /** Stores settings which specify where and to what precision a floating point operation should be performed.
     **/
    public class CDevice
    {
        EFloatingPointPrecision _fpp;
        EFloatingPointUnit _fpu;
        uint _device_number;

        public CDevice(EFloatingPointPrecision fpp, EFloatingPointUnit fpu, uint device_number)
        {
            _fpp = fpp;
            _fpu = fpu;
            _device_number = device_number;
        }

        /** The precision of the floating point operation.
         **/
        public EFloatingPointPrecision fpp
        {
            get
            {
                return _fpp;
            }
        }

        /** The type of calculation unit which should perform the floating point operation.
         **/
        public EFloatingPointUnit fpu
        {
            get
            {
                return _fpu;
            }
        }

        /** The index of a particular calculation unit of type fpu.
         * Combined with fpu this uniquely specifies the calculation unit.
         **/
        public uint device_number
        {
            get
            {
                return _device_number;
            }
        }
    }
}
