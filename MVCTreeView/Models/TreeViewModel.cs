using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTreeView.Models
{
	public class Model
	{
		public Model()
		{
			this.List = new List<Model>();
		}

		public string Id { get; set; }

		public string Name { get; set; }

		public string Type { get; set; }

		public IList<Model> List { get; private set; }

		public bool IsChild
		{
			get
			{
				return this.List.Count == 0;
			}

		}

	}
}