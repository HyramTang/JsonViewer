﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EPocalipse.Json.Viewer;
using Fiddler;
using System.Drawing;

namespace EPocalipse.Json.Fiddler
{
	public sealed class JsonResponseInspector: JsonInspectorBase, IResponseInspector2
	{
		public HTTPResponseHeaders headers
	        {
	            get
	            {
	                return null;
	            }
	            set
	            {
	                _headers = value;
	            }
	        }
	}
}
