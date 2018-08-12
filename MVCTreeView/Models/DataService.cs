using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTreeView.Models
{
	public static class DataService
	{
		public static  List<Folder> GetFolders()
		{
			var lstFolders = new List<Folder>
			{
				  new Folder{ FolderID = "1",Name ="Root1" },
				  new Folder{ FolderID ="2", Name ="Root2"  },
				  new Folder{ FolderID ="3", Name ="Root3"  },
				  new Folder{ FolderID ="4", Name ="Root4" },
				  new Folder{ FolderID ="5", Name ="Root5"  }
			};
			return lstFolders;
		}
		public static List<SubFolder> GetSubFolders()
		{
			var lstSubFolders = new List<SubFolder>
			{
				  new SubFolder { SubFolderID ="1a", FolderID ="1",Name ="Folder1a"},
				  new SubFolder { SubFolderID ="1b", FolderID ="1",Name ="Folder1b"},
				  new SubFolder { SubFolderID ="2a", FolderID ="2",Name ="Folder2"},
				  new SubFolder { SubFolderID ="3a", FolderID ="3",Name ="Folder3"},
				  new SubFolder { SubFolderID ="4a", FolderID ="4",Name ="Folder4"},
				  new SubFolder { SubFolderID ="5a", FolderID ="5",Name ="Folder5"},

			};
			return lstSubFolders;
		}
		public static List<InternalFolder> GetInternalFolders()
		{
			var lstInternalFolders = new List<InternalFolder>
			{
				  new InternalFolder { SubFolderID ="1a", InternalFolderID ="1aa",Name ="InternalFolder1a"},
				  new InternalFolder { SubFolderID ="1b", InternalFolderID ="1bb",Name ="InternalFolder1b"},
				  new InternalFolder { SubFolderID ="2a", InternalFolderID ="2aa",Name ="InternalFolder2"},
				  new InternalFolder { SubFolderID ="3a", InternalFolderID ="3aa",Name ="InternalFolder3"},
				  new InternalFolder { SubFolderID ="4a", InternalFolderID ="4aa",Name ="InternalFolder4"},
				  new InternalFolder { SubFolderID ="5a", InternalFolderID ="5aa",Name ="InternalFolder5"},

			};
			return lstInternalFolders;
		}
	}
}