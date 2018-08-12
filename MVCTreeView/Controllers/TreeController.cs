using MVCTreeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTreeView.Controllers
{
    public class TreeController : Controller
	{
		public ActionResult Index()
		{

			//get list to pass to data in view

			IList<Model> folders = FoldersList();

			return View(folders);

		}

		public IList<Model> FoldersList()
		{
			IList<Model> folders = new List<Model>();

			foreach (var objfolder in DataService.GetFolders())
			{

				var fold = new Model
				{
					Id = objfolder.FolderID,
					Name = objfolder.Name
				};

				foreach (var objSubFolder in objfolder.SubFolders)
				{
					var sub = new Model
					{

						Id = objSubFolder.SubFolderID,

						Name = objSubFolder.Name,

					};

					foreach (var objinternalFolder in objSubFolder.InternalFolders)
					{

						var subInternal = new Model
						{
							Id = objinternalFolder.InternalFolderID,
							Name = objinternalFolder.Name,
						};

						sub.List.Add(subInternal);
					}

					fold.List.Add(sub);
				}

				folders.Add(fold);
			}

			return folders;
		}

	}
}