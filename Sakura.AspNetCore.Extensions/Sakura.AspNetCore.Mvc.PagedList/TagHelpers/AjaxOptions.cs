﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sakura.AspNetCore.Mvc.TagHelpers
{
	/// <summary>
	/// Provide the AJAX options.
	/// </summary>
    public class AjaxOptions
    {
		public bool Enabled { get; set; }

		public AjaxUpdateMode UpdateMode { get; set; }
    }

	/// <summary>
	/// Define the update mode for AJAX operation results.
	/// </summary>
	public enum AjaxUpdateMode
	{
		/// <summary>
		/// The fetched content will be placed before the target element.
		/// </summary>
		Before,
		/// <summary>
		/// The fetched content will be placed after the target element.
		/// </summary>
		After,
		/// <summary>
		/// The fetched content with replace the target element.
		/// </summary>
		ReplaceWith
	}
}
