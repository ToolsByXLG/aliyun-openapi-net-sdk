/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Airec.Model.V20181012
{
	public class DeleteDiversifyResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private DeleteDiversify_Result result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public DeleteDiversify_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DeleteDiversify_Result
		{

			private string name;

			private string gmtCreate;

			private string gmtModified;

			private DeleteDiversify_Parameter parameter;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public DeleteDiversify_Parameter Parameter
			{
				get
				{
					return parameter;
				}
				set	
				{
					parameter = value;
				}
			}

			public class DeleteDiversify_Parameter
			{

				private int? categoryIndex;

				private int? window;

				public int? CategoryIndex
				{
					get
					{
						return categoryIndex;
					}
					set	
					{
						categoryIndex = value;
					}
				}

				public int? Window
				{
					get
					{
						return window;
					}
					set	
					{
						window = value;
					}
				}
			}
		}
	}
}