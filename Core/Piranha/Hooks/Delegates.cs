﻿using System;
using System.Text;

namespace Piranha.Hooks
{
	/// <summary>
	/// The standard delegates available.
	/// </summary>
	public static class Delegates
	{
		/// <summary>
		/// Delegate for creating an object of the specified type.
		/// </summary>
		/// <typeparam name="T">The object type</typeparam>
		/// <returns>The crated object</returns>
		public delegate T CreateDelegate<T>();

		/// <summary>
		/// Delegate for returning a string to be rendered.
		/// </summary>
		/// <typeparam name="T">The model type</typeparam>
		/// <param name="model">The model</param>
		/// <returns>The rendered output</returns>
		public delegate string OutputReturnDelegate<T>(T model);

		/// <summary>
		/// Delegate for appending rendered output to a string builder.
		/// </summary>
		/// <typeparam name="T">The model type</typeparam>
		/// <param name="sb">The string builder</param>
		/// <param name="model">The model</param>
		public delegate void OutputAppendDelegate<T>(StringBuilder sb, T model);

		/// <summary>
		/// Delegate for appending rendered output to a string builder.
		/// </summary>
		/// <param name="sb">The string builder</param>			
		public delegate void OutputAppendDelegate(StringBuilder sb);

		/// <summary>
		/// Delegate for handling a generic event.
		/// </summary>
		/// <param name="sender">The event sender</param>
		/// <param name="e">Optional event arguments</param>
		public delegate void EventDelegate(object sender, EventArgs e);

		/// <summary>
		/// Delegate for model hooks.
		/// </summary>
		/// <typeparam name="T">The model type</typeparam>
		/// <param name="model">The model</param>
		public delegate void ModelHook<T>(T model) ;
	}
}