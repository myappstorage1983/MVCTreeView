using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTreeView.Models
{
	
	public class Folder
	{
		public string FolderID { get; set; }

		public string Name { get; set; }

		public  List<SubFolder> SubFolders {
			get => DataService.GetSubFolders().Where(t => t.FolderID == FolderID).ToList();
		}
	}

	public class SubFolder
	{
		public string SubFolderID { get; set; }

		public string Name { get; set; }

		public  List<InternalFolder> InternalFolders {
			get => DataService.GetInternalFolders().Where(t => t.SubFolderID == SubFolderID).ToList();
		}

		public string FolderID { get; set; }


	}

	public class InternalFolder
	{

		public string InternalFolderID { get; set; }

		public string Name { get; set; }

		public string SubFolderID { get; set; }


	}



}