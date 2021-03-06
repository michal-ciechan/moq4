﻿//Copyright (c) 2007. Clarius Consulting, Manas Technology Solutions, InSTEDD
//https://github.com/moq/moq4
//All rights reserved.

//Redistribution and use in source and binary forms, 
//with or without modification, are permitted provided 
//that the following conditions are met:

//    * Redistributions of source code must retain the 
//    above copyright notice, this list of conditions and 
//    the following disclaimer.

//    * Redistributions in binary form must reproduce 
//    the above copyright notice, this list of conditions 
//    and the following disclaimer in the documentation 
//    and/or other materials provided with the distribution.

//    * Neither the name of Clarius Consulting, Manas Technology Solutions or InSTEDD nor the 
//    names of its contributors may be used to endorse 
//    or promote products derived from this software 
//    without specific prior written permission.

//THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
//CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
//INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
//MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
//DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
//CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
//SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
//BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
//SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
//INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
//WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
//NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
//OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
//SUCH DAMAGE.

//[This is the BSD license, see
// http://www.opensource.org/licenses/bsd-license.php]

using System;
using System.ComponentModel;
using Moq.Language.Flow;
using Moq.Proxy;

namespace Moq.Language
{
	/// <summary>
	/// Defines the <c>Returns</c> verb.
	/// </summary>
	/// <typeparam name="TMock">Mocked type.</typeparam>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IReturnsAnyType<TMock> : IFluentInterface
	{
		/// <summary>
		/// Specifies a function that will calculate the value to return from an open generic method.
		/// </summary>
		/// <param name="valueFunction">
		/// The function that will calculate the return value.
		/// IPublicCallContext contains the closed generic method as well as the arguments passed in.
		/// </param>
		/// <example group="returns">
		/// Return a calculated value when the method is called:
		/// <code>
		/// mock.Setup(x => x.Execute&lt;It.IsAnyType>())
		///     .Returns(context => returnValues[0]);
		/// </code>
		/// The lambda expression to retrieve the return value is lazy-executed, 
		/// meaning that its value may change depending on the moment the method 
		/// is executed and the value the <c>returnValues</c> array has at 
		/// that moment.
		/// </example>
		IReturnsResult<TMock> Returns(Func<ICallContext, object> valueFunction);
	}
}