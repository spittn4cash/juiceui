﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

using Juice.Framework;

namespace Juice.Mobile {

	/// <summary>
	/// LI within a navbar.
	/// </summary>
	[ParseChildren(false)]
	public class NavbarItem : System.Web.UI.WebControls.WebControl {

		public NavbarItem() : base(null) { }

		protected override System.Web.UI.HtmlTextWriterTag TagKey { get { return System.Web.UI.HtmlTextWriterTag.Li; } }
	}
}
